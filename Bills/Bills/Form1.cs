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

namespace Bills
{
    public partial class Form1 : Form
    {
        bool _bMouseIsDown;
        object _lock = new object();
        Point _startP = new Point(0,0);
        Point _startMouseP = new Point();
        public Form1()
        {
            InitializeComponent();
            CTCT.instance.Version = "bills -- V" + System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTransact();
            IniCtronl();
        }
        //初始化控件
        private void IniCtronl()
        {
            Version.Text = CTCT.instance.Version;
        }
        //事件初始化
        private void InitTransact()
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = (MouseEventArgs)e;
            if (btn.Button == MouseButtons.Left)
            {
                _bMouseIsDown = true;
                _startP = Control.MousePosition;
                _startMouseP = new Point(this.Left, this.Top);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _bMouseIsDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //在标题栏按下鼠标左键能够移动主界面
            lock(_lock)
            {
                var btn = (MouseEventArgs)e;
                if (btn.Button == MouseButtons.Left)
                {
                    Point endP = new Point(Control.MousePosition.X, Control.MousePosition.Y);
                    if (endP == _startP) return;
                    this.Left = _startMouseP.X + endP.X - _startP.X;
                    this.Top = _startMouseP.Y + endP.Y - _startP.Y;
                }
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
