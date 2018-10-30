using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MakeSureForm : Form
    {
        public bool isOK
        {
            get
            {
                return _isOK;
            }
        }
        bool _isOK;
        public string FromFile
        {
            get
            {
                return _fromFile;
            }
            set
            {
                _fromFile = value;
                textBox1.Text = _fromFile;
            }
        }
        string _fromFile;
        public string TargetFile
        {
            get
            {
                return _targetFile;
            }
            set
            {
                _targetFile = value;
                textBox2.Text = _targetFile;
            }
        }
        string _targetFile;
        public MakeSureForm()
        {
            InitializeComponent();
        }

        private void msOk_but_Click(object sender, EventArgs e)
        {
            _isOK = true;
            Visible = false;
            Update();         
        }

        private void msCanc_but_Click(object sender, EventArgs e)
        {
            _isOK = false;
            Visible = false;           
        }
    }
}
