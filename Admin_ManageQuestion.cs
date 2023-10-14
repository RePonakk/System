using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace 试题库管理系统
{
    public partial class Admin_ManageQuestion : Form
    {
        Form reform;
        public Admin_ManageQuestion(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_ChangeQuestion admin_ChangeQuestion = new Admin_ChangeQuestion(this);
            admin_ChangeQuestion.Visible= true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_DropQuestion admin_DropQuestion = new Admin_DropQuestion(this);
            admin_DropQuestion.Visible= true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_AddQuestion admin_addquestion = new Admin_AddQuestion(this);
            admin_addquestion.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_AddQuestions admin_AddQuestions = new Admin_AddQuestions(this);
            admin_AddQuestions.Visible = true;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_FindQuestion admin_FindQuestion = new Admin_FindQuestion(this);
            admin_FindQuestion.Visible = true;
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
