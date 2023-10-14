using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NPOI.SS.Formula.Functions;

namespace 试题库管理系统
{
    public partial class Admin_ManageSubject : Form
    {
        Form reform;
        public Admin_ManageSubject(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Admin_AddSubject admin_addsubject = new Admin_AddSubject(this);
            admin_addsubject.Visible = true;
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_ChangeSubject admin_changesubject = new Admin_ChangeSubject(this);
            admin_changesubject.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_FindSubject admin_findsubject = new Admin_FindSubject(this);
            admin_findsubject.Visible = true;
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Admin_DropSubject admin_dropsubject = new Admin_DropSubject(this);
            admin_dropsubject.Visible = true;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
