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
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_ManageUser admin_manageuser = new Admin_ManageUser(this);
            admin_manageuser.Visible = true;
            this.Hide();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Admin_ManageSubject admin_managesubject = new Admin_ManageSubject(this);
            admin_managesubject.Visible = true;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_ManagePoint admin_managepoint = new Admin_ManagePoint(this);
            admin_managepoint.Visible = true;
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_ManageQuestion admin_managequestion = new Admin_ManageQuestion(this);  
            admin_managequestion.Visible = true;
            this.Hide();
        }
    }
}
