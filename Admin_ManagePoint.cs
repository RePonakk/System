using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 试题库管理系统
{
    public partial class Admin_ManagePoint : Form
    {
        Form reform;
        public Admin_ManagePoint(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_AddPoint admin_addpoint = new Admin_AddPoint(this);
            admin_addpoint.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_ChangePoint admin_changepoint = new Admin_ChangePoint(this);
            admin_changepoint.Visible = true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_DropPoint admin_droppoint = new Admin_DropPoint(this);
            admin_droppoint.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_FindPoint admin_findpoint = new Admin_FindPoint(this);
            admin_findpoint.Visible = true;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }

       
    }
}
