using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.Common;
using Newtonsoft.Json;
using System.Security.Cryptography;
namespace WindowsFormsApplication2
{
    public partial class CopyLog : Form
    {
        MakeSureForm msForm;
        TaskFinishDialog finishForm;
        Thread watchDevicesChangesThread;//监视磁盘的线程
        Thread resetStatusTextThread;//恢复状态栏线程，未编写
        readonly int FLASH_TIME_INTERVAL = 300;//ms
        bool closeForm;
        private bool _isFormActive;
        private bool _isStatusNeedFlash=false;
        ConfigFile _config;
        HashSet<string> _drvs;
        class StatusBarObject
        {
            public int time = 0;
        }
        delegate void UpdateFileList(object value);
        delegate void UpdateStatusBar(object obj);
        //磁盘操作函数
        private void _updateFromFileListFunc(object _list)
        {
            if (fromFile_comb.InvokeRequired)
            {
                UpdateFileList _updateFileList = new UpdateFileList(_updateFromFileListFunc);
                fromFile_comb.Invoke(_updateFileList, new object[] { _list });
            }
            else
            {
                List<string> _list_ = _list as List<string>;
                fromFile_comb.Text = "";
                fromFile_comb.DataSource = _list;
                if (_list_.Count != 0)
                {
                    Visible = true;
                    Activate();
                    setStatusText("更新来源文件...");
                }
            }
        }
        //状态栏显示处理函数
        private void _updateStatusBarFunc(object _obj)
        {
            if (this.InvokeRequired)
            {
                UpdateStatusBar _updateStatusBar = new UpdateStatusBar(_updateStatusBarFunc);
                this.Invoke(_updateStatusBar, new object[] { _obj });
            }
            else
            {
                StatusBarObject obj = _obj as StatusBarObject;
                if (obj.time == 0)
                {
                    toolStripStatusLabel1.Text = "";
                }
                else if (obj.time < 5)
                {
                    toolStripStatusLabel1.Visible = (obj.time % 2 == 1) ? true : false;
                }
                else {
                    toolStripStatusLabel1.Visible = true;
                }
            }
        }
        public CopyLog()
        {
            InitializeComponent();
            init();
            initDelegate();
            startThread();
        }
        //开启磁盘监视和状态栏线程
        private void startThread()
        {
            #region thread_for_watchDevices
            watchDevicesChangesThread = new Thread(new ThreadStart(()=>{
                while (true)
                {
                    Thread.Sleep(500);
                    if (closeForm)
                    {
                        break;
                    }
                    DriveInfo[] dis=DriveInfo.GetDrives();
                    HashSet<string> _tmp = new HashSet<string>();
                    List<string> _diff_drv = new List<string>();
                    List<string> _find_files = new List<string>();
                    foreach (var di in dis)//获取当前所有盘符
                    {
                       _tmp.Add(di.Name);
                    }                  
                    foreach (var item in _tmp)//与之前盘符比较，如果有之前不存在的盘符，则包装进行后期访问
                    {
                        if (!_drvs.Contains(item))
                        {
                            _diff_drv.Add(item);
                        }
                    }
                    if (_diff_drv.Count > 0)//这里进行对不同的驱动器进行处理
                    {                       
                        foreach (var  item in _diff_drv)
                        {
                            try {
                                foreach (var file in Directory.EnumerateFiles(item, "r*.txt")) {
                                    _find_files.Add(file);
                                }                              
                            }
                            catch (IOException)
                            {
                                Console.WriteLine("Exception on EnumerateFiles:" + item);
                            }
                        }
                        
                    }
                    if(_drvs.Count!=_tmp.Count)//如果比较后相同就不进行赋值操作  ,最拙劣的判断是否变化方法
                    {
                        _updateFromFileListFunc(_find_files);
                        _drvs = _tmp;
                    }                                      
                }
            }));
            watchDevicesChangesThread.Start();
            #endregion
            #region thread_for_change_statusbar_status
            resetStatusTextThread = new Thread(new ThreadStart(() => {
                StatusBarObject sbo = new StatusBarObject();
                while (true)
                {
                    if (closeForm)
                    {
                        break;
                    }
                    Thread.Sleep(FLASH_TIME_INTERVAL);
                    if (_isStatusNeedFlash)//如果状态栏需要闪动
                    {
                        sbo.time++;
                        _updateStatusBarFunc(sbo);                       
                        if (sbo.time > 9)
                        {
                            _isStatusNeedFlash = false;
                            sbo.time = 0;
                            _updateStatusBarFunc(sbo);
                        }
                    }
                }

            }));
            resetStatusTextThread.Start();
            #endregion
        }
        //初始化两个提示框的委托，绑定到当前方法
        private void initDelegate()
        {
            msForm.VisibleChanged += MsForm_VisibleChanged;
            finishForm.VisibleChanged += FinishForm_VisibleChanged;
        }

        private void FinishForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!finishForm.Visible)//这里进行打开
            {

            }
        }
        //当确认复制框隐藏后，执行对应操作
        private void MsForm_VisibleChanged(object sender, EventArgs e)
        {           
            if (!msForm.Visible&&msForm.isOK)// 这里开始复制工作
            {
                if (checkBox1.Checked&&!Directory.Exists(targetDir.Text + "\\" + newTargetDir_input.Text))//当需要建立文件夹时
                {
                    Directory.CreateDirectory(targetDir.Text+"\\"+newTargetDir_input.Text);
                }
                if (File.Exists(msForm.FromFile) && !File.Exists(msForm.TargetFile))
                {
                    File.Copy(msForm.FromFile, msForm.TargetFile);
                    byte[] str1 = File.ReadAllBytes(msForm.FromFile);
                    byte[] str2 = File.ReadAllBytes(msForm.TargetFile);
                    if (isSameString(str1, str2))
                    {
                        finishForm.FromFile = msForm.FromFile;
                        finishForm.TargetFolder = targetDir.Text;
                        finishForm.ShowDialog();
                        flyTime_num.Value = flyTime_num.Value + 1;
                    }
                    else
                    {
                        MessageBox.Show("复制失败或者校验失败，请手动检查", "出现问题");
                    }
                } 
            }
        }
        //获取当前日期字符串，如20180910
        private string getDate()
        {
            DateTime dt = DateTime.Now;
            return "" + dt.Year + dt.Month + dt.Day;
        }
        //初始化，包括初始化几个对话框对象，读取配置文件并设置界面值
        private void init()
        {
            msForm = new MakeSureForm();
            finishForm = new TaskFinishDialog();
            closeForm = false;
            _drvs = new HashSet<string>();
            newTargetDir_input.Text = getDate();
            _config=new ConfigFile(AppDomain.CurrentDomain.BaseDirectory+"\\config.json");
            if (_config.isError)
            {
                setStatusText("加载配置文件失败");
                vehicleType_comb.DataSource = _config.getVehicleTypes();
                spot_cmb.DataSource = _config.getSpots();
            }
            else
            {
                selectFolder_dia.SelectedPath = _config.getTargetFolder();
                targetDir.Text = _config.getTargetFolder();
                checkBox1.Checked = _config.isCreateFolder();
                vehicleType_comb.DataSource = _config.getVehicleTypes();
                if (_config.getVehicleTypes().Count > _config.getLastTypeIndex())
                    vehicleType_comb.SelectedIndex = _config.getLastTypeIndex();
                else
                    vehicleType_comb.SelectedIndex = 0;
               spot_cmb.DataSource = _config.getSpots();
                if (_config.getSpots().Count > _config.getLastSpotIndex())
                    spot_cmb.SelectedIndex = _config.getLastSpotIndex();
                else
                    vehicleType_comb.SelectedIndex = 0;
               newTargetDir_input.Enabled = _config.isCreateFolder();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = selectFile_dia.ShowDialog();
            if (dr == DialogResult.OK)
            {
                fromFile_comb.Text = selectFile_dia.FileName;
            }
        }

        private void targetDirSelect_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = selectFolder_dia.ShowDialog();
            if (dr == DialogResult.OK)
            {
                targetDir.Text = selectFolder_dia.SelectedPath;
                Console.WriteLine(selectFolder_dia.SelectedPath);
                
            }
        }
        //建立新的文件夹
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            newTargetDir_input.Enabled = checkBox1.Checked;
            if (targetDir.Text != "")
            {
                if (checkBox1.Checked)
                {
                    targetDir.Text = targetDir.Text.TrimEnd(new char[] { '\\'}) + "\\" + newTargetDir_input.Text;
                }
                else
                {
                    string ttext = targetDir.Text,ntext= newTargetDir_input.Text;
                    if (ttext.EndsWith(ntext))
                    {
                        var path= ttext.Substring(0, ttext.Length - ntext.Length - 1);//减去路径的斜杠一个字符
                        if (path.EndsWith(":"))//如果zhi
                            path += "\\";
                        targetDir.Text = path;
                    }
                }
            }
        }

        private void CopyLog_Deactivate(object sender, EventArgs e)
        {
            _isFormActive = false;
        }

        private void CopyLog_VisibleChanged(object sender, EventArgs e)
        {
            _isFormActive = Visible;
        }

        private void CopyLog_Activated(object sender, EventArgs e)
        {
            _isFormActive = true;
        }
        //窗口关闭按钮点击后，不可见该窗口
        private void CopyLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
            if(!closeForm)
                notifyIcon1.ShowBalloonTip(1000, "logCopy隐藏在这里", "继续监听磁盘驱动器变化", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {    
            Visible = true;
            Activate();
        }
        //在右下点击退出后处理时间
        private void closeApplication_Click(object sender, EventArgs e)
        {
            saveConfig();
            closeForm = true;
            Thread.Sleep(1000);
            this.Close();
            notifyIcon1.Visible = false;
            System.Environment.Exit(0);
        }
        private void saveConfig()
        {
            _config.setComment(comment_txt.Text);
            _config.setIsCreateFolder(checkBox1.Checked);
            _config.setTargetFolder(targetDir.Text);
            _config.setLastSpotIndex(spot_cmb.SelectedIndex);
            _config.setLastVehicleTypeIndex(vehicleType_comb.SelectedIndex);
            string ff = fromFile_comb.Text;
            if(ff.LastIndexOf("\\")>0)
                _config.setFromFolder(ff.Substring(0, ff.LastIndexOf("\\")));
            _config.save();
        }
        //获得最终的保存文件名称
        private string _getFinalTargetName()
        {
            return vehicleType_comb.Text //飞机类型
                + "-" +flyTime_num.Value//飞行架次
                + "-" + getDate()//日期
                + "-" + "02" //这个我不知道
                + "-" + spot_cmb.Text//测试场地
                + "-" + comment_txt.Text 
                + ".bin";
        }
        //复制按钮点击后
        private void button2_Click(object sender, EventArgs e)
        {
            if (targetDir.Text.EndsWith("\\"))
            {
                targetDir.Text = targetDir.Text.TrimEnd(new char[] { '\\' });
            }
            var tf= targetDir.Text + "\\" + _getFinalTargetName();
            if (fromFile_comb.Text==""|| targetDir.Text == "")
            {
                setStatusText("输入文件和输出文件夹都不能为空");
            }
            else if (!File.Exists(fromFile_comb.Text))
            {
                setStatusText("源文件不存在: "+ fromFile_comb.Text);
            }else if (File.Exists(tf))
            {
                setStatusText("目标文件已存在: " + tf);
            }
            else
            {
                if (!(spot_cmb.DataSource as List<string>).Contains(spot_cmb.Text))
                {
                    _config.getSpots().Add(spot_cmb.Text);
                    spot_cmb.DataSource = null;
                    spot_cmb.DataSource = _config.getSpots();
                }
                if (!(vehicleType_comb.DataSource as List<string>).Contains(vehicleType_comb.Text))
                {
                    _config.getVehicleTypes().Add(vehicleType_comb.Text);
                    vehicleType_comb.DataSource = _config.getVehicleTypes();
                }
                saveConfig();
                msForm.FromFile = fromFile_comb.Text;
                msForm.TargetFile = tf;
                msForm.ShowDialog();
            }           
        }       
        //计算两个byte数组的md5值并比较其是否相同，用于校验复制的两个文件是否一致
        private bool isSameString(byte[] str1,byte[] str2)
        {
            MD5CryptoServiceProvider prv = new MD5CryptoServiceProvider();
            byte[] hash1=prv.ComputeHash(str1);
            byte[] hash2 = prv.ComputeHash(str2);
            bool rlt = true;
            for(int i = 0; i < hash1.Length; i++)
            {
                if (hash1[i] != hash2[i])
                {
                    rlt = false;
                    break;
                }
            }
            return rlt;
        }

        private void targetDir_TextChanged(object sender, EventArgs e)
        {
            if (targetDir.Text == "")
                return;
            if (Directory.Exists(targetDir.Text))
            {
                selectFolder_dia.SelectedPath = targetDir.Text;
                /*
                if (checkBox1.Checked)
                {
                    string ttt = targetDir.Text;
                    if (ttt.EndsWith("\\"))
                    {
                        ttt.TrimEnd(new char[] { '\\'});
                    }
                    targetDir.Text = ttt + "\\" + newTargetDir_input.Text;
                } 
                */              
            }
            else
            {                
                setStatusText("不存在目录:" + targetDir.Text+"，请更换其他目录");
            }
        }
        //设置状态栏显示文字内容，包括设置状态栏的显示，格式
        private void setStatusText(string text)
        {
            DateTime dt = DateTime.Now;           
            toolStripStatusLabel1.Text=dt.ToString("[MM-dd hh:mm:ss]   ") + text;
            _isStatusNeedFlash = true;
        }
        //关于
        private void aboutApplication_Click(object sender, EventArgs e)
        {
            List<string> about = new List<string>();
            about.Add("2018-10-30");
            if (File.Exists("about.me"))
            {
                about.AddRange(File.ReadAllLines("about.me").ToList());
            }
            else
            {
                about.Add("1)可通过编辑config.json文件来更改一些默认的设置");
                about.Add("可通过编辑config文件来更改一些默认的设置等");
                about.Add("可通过编辑config文件来更改一些默认的设置等");
                about.Add("可通过编辑config文件来更改一些默认的设置等");
                about.Add("可通过编辑config文件来更改一些默认的设置等");
                about.Add("可通过编辑config文件来更改一些默认的设置等");
                about.Add("可通过编辑config文件来更改一些默认的设置等");
                about.Add("可通过编辑config文件来更改一些默认的设置等");
                about.Add("可通过编辑config文件来更改一些默认的设置等");
                about.Add("可通过编辑config文件来更改一些默认的设置等");
            }
            MessageBox.Show(string.Join("\r\n", about), "关于");
        }
    }
    
}
