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
    /// <summary>
    /// PatternSelectWindow.xaml 的交互逻辑
    /// </summary>
    

    public partial class Admin_ManageUser : Form
    {
        Form reform;
        public Admin_ManageUser(Form reform)
        {
            InitializeComponent();
            this.reform = reform;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_AddUser admin_adduser = new Admin_AddUser(this);
            admin_adduser.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_ResetUserPassword admin_resetuserpassword = new Admin_ResetUserPassword(this);
            admin_resetuserpassword.Visible = true;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
