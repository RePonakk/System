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
    public partial class User_ManagePaper : Form
    {
        Form reform;
        public User_ManagePaper(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
