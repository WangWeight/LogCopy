using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class TaskFinishDialog : Form
    {
        public string FromFile
        {
            set
            {
                _fromFile = value;
                int _last_slash = _fromFile.LastIndexOf("\\");
                if (_last_slash> 0)
                {
                    _fromFolder = _fromFile.Substring(0, _last_slash);
                }
                else
                {
                    _fromFolder = "";
                }
            }
        }
        string _fromFolder;
        string _fromFile;

        public string TargetFolder
        {
            set
            {
                _targetFolder = value;
            }
        }
        string _targetFolder;
        public TaskFinishDialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", _fromFolder);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(_fromFile);
            }
            catch (IOException)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", _targetFolder);
        }
    }
}
