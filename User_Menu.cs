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
    public partial class User_Menu : Form
    {
        public User_Menu(string acc)
        {
            this.acc = acc;
            InitializeComponent();
        }
        private string acc;

        private void button1_Click(object sender, EventArgs e)
        {
            User_ResetUserPassword user_resetpassword = new User_ResetUserPassword(acc,this);
            user_resetpassword.Visible = true;
            this.Hide();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            User_FindPaper user_findpaper = new User_FindPaper(this);
            user_findpaper.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_AddPaper user_addpaper = new User_AddPaper(this);
            user_addpaper.Visible = true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User_ManagePaper user_managepaper = new User_ManagePaper(this);
            user_managepaper.Visible = true;
            this.Hide();
        }
    }
}
