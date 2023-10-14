using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 试题库管理系统
{
    public partial class begin : Form
    {
        public begin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            User user = new User();
            user.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin admin = new Admin(this);
            admin.Visible = true;
        }

        private void begin_SizeChanged(object sender, EventArgs e)
        {
            //当窗体最小化时
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏窗体
                Hide();
                //将托盘图标设为显示
                notifyIcon1.Visible = true;
            }
            else
            {
                //将托盘图标设为隐藏
                notifyIcon1.Visible = false;
                //显示窗体
                Show();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            //恢复窗体尺寸状态
            this.WindowState = FormWindowState.Normal;
        }
    }
}
