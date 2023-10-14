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
    public partial class User_AddPaper : Form
    {
        Form reform;

        public User_AddPaper(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_AddSinglePaper user_AddSinglePaper = new User_AddSinglePaper(this);
            user_AddSinglePaper.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_AddDoublePapers user_AddDoublepapers = new User_AddDoublePapers(this);
            user_AddDoublepapers.Show();
            this.Hide();
        }
    }
}
