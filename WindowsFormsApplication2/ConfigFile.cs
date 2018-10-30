using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace WindowsFormsApplication2
{
    /// <summary>
    ///    配置文件类 ,用于配置文件的读写，获取配置文件中的内容。可让用户直接编写配置文件，但是如果出现错误，软件界面也会提示
    /// </summary>
    /*
{
  "FromFolder": "D:",
  "TargetFolder": "c:\\20181029",
  "VehicleType": [
    "type1",
    "type2"
  ],
  "LastTypeIndex": 0,
  "Spot": [
    "营口场地",
    "法库场地",
    "铁岭场地"
  ],
  "VehicleNo":[],
  "FlyItem":"",
  "LastSpotIndex": 0,
  "IsCreateFolder": true,//取消掉该记录
  "Comment": "buzhis "
}
    */
    class JsonObject
    {
        public string FromFolder;//原目录
        public string TargetFolder;//目标目录
        public List<string> VehicleType;//飞行器类型
        public int LastTypeIndex;//选择类型的序号
        public List<string> Spot;//地点
        public int LastSpotIndex;//地点序号
        public string FlyItem;//飞行科目
        public List<string> VehicleNo;//飞机编号
        public bool IsCreateFolder;//是否新建文件夹
        public string Comment;//备注？这里还不确定是否使用list来存储多个备注
        public JsonObject()
        {
            VehicleType = new List<string>();
            Spot = new List<string>();
            VehicleNo = new List<string>();
        }
    }
    class ConfigFile
    {
        string _file;
        public bool isError
        {
            get
            {
                return _isError;
            }
        }
        bool _isError;//返回是否出错，在读取中用于判断
        JsonObject _jo;
        //清除掉列表中只包含空格的部分
        private void removeEmptyItem(List<string> _list)
        {
            if (_list != null)
            {
                for (int i = _list.Count - 1; i >= 0; i--)
                {
                    if (_list[i].Trim(new char[] { ' '}).Equals(""))
                    {
                        _list.RemoveAt(i);
                    }
                }
            }
            else
            {
                _list = new List<string>();
            }
        }
        public ConfigFile(String file)
        {
            _file = file;
            if (File.Exists(_file))
            {
                TextReader tr = new StreamReader(file, Encoding.UTF8);
                string content = tr.ReadToEnd();
                tr.Close();
                try
                {
                    JsonObject jo = JsonConvert.DeserializeObject<JsonObject>(content);
                    if (jo != null)
                    {
                        _jo = jo;
                        removeEmptyItem(_jo.Spot);
                        removeEmptyItem(_jo.VehicleType);
                        removeEmptyItem(_jo.VehicleNo);
                        _isError = false;
                    }
                    else
                    {
                        _isError = true;
                        _jo = new JsonObject();
                    }
                }
                catch (JsonException e)
                {
                    _isError = true;
                    _jo = new JsonObject();
                }
            }
            else
            {
                _jo = new JsonObject();
                _isError = true;
            }                         
        }
        public String getFromFolder()
        {
            return _jo.FromFolder;
        }
        public void setFromFolder(string folder)
        {
            _jo.FromFolder=folder;
        }
        public String getTargetFolder()
        {
            return _jo.TargetFolder;
        }
        public void setTargetFolder(string folder)
        {
            _jo.TargetFolder = folder;
        }
        public List<String> getVehicleTypes()
        {
            return _jo.VehicleType;
        }
        public int getLastTypeIndex()
        {
            return _jo.LastTypeIndex;
        }
        public void setLastVehicleTypeIndex(int index)
        {
            _jo.LastTypeIndex = index;
        }
        public bool isCreateFolder()
        {
            return _jo.IsCreateFolder;
        }
        public void setIsCreateFolder(bool isC)
        {
            _jo.IsCreateFolder=isC;
        }
        public List<string> getVehicleNo()
        {
            return _jo.VehicleNo;
        }
        public void setVehicleNo(List<string> vn)
        {
            _jo.VehicleNo = vn;
        }
        public String getComment()
        {
            return _jo.Comment;
        }
        public void setComment(string cmt)
        {
            _jo.Comment=cmt;
        }
        
        public List<string> getSpots()
        {
            return _jo.Spot;
        }
        public void setSpots(List<string> spots)
        {
            _jo.Spot = spots;
        }
        public void setFlyItem(string item)
        {
            _jo.FlyItem = item;
        }
        public string getFlyItem()
        {
            return _jo.FlyItem;
        }
        public int getLastSpotIndex()
        {
            return _jo.LastSpotIndex;
        }        
        public void setLastSpotIndex(int index)
        {
            _jo.LastSpotIndex = index;
        }
        //用于调试在console中输出对象字符串
        public void print()
        {
            
            Console.WriteLine(JsonConvert.SerializeObject(_jo, Formatting.Indented));
        }
        public bool save(string file)
        {
            try { 
                TextWriter tw = new StreamWriter(file, false);
                tw.Write(JsonConvert.SerializeObject(_jo, Formatting.Indented));
                tw.Close();
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        public bool save()
        {
            return save(_file);
        }
    }
}
