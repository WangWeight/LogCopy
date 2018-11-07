using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCoooooooopy
{
    class AboutMe
    {
        string _version = "ver 1.0.5";
        public string Version
        {
            get
            {
                return _version;
            }
        }
        public string message()
        {
            List<string> msg = new List<string>();
            msg.Add("1)修复getDate中日月可能一位数字问题");
            msg.Add("2)增加版本号码显示以及更新内容提示");
            msg.Add("3)将状态栏信息从隐藏显示动画更换为空字符串和字符串显示");
            msg.Add("4)修复新打开软件时不填充备注信息的问题");
            return string.Join("\n", msg);
        }
    }
}
