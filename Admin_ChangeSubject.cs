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
    public partial class Admin_ChangeSubject : Form
    {
        Form reform;
        public Admin_ChangeSubject(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oldname = txt_old.Text;
            string newname = txt_new.Text;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            MySqlConnection connection;//定义与数据连接的链接
            MySqlCommand command;
            string sql;

            builder.UserID = "root";//用户
            builder.Password = "123456";//密码
            builder.Server = "localhost";
            builder.Database = "test_database";//数据库名
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            if (string.IsNullOrEmpty(oldname) || string.IsNullOrEmpty(newname))
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }

            if (oldname == newname)
            {
                MessageBox.Show("修改后名称不可与原名称相同！" + '\n' + "请重新输入");
            }

            sql = "select count(*) from subject where sname = '" + oldname + "'";
            command = new MySqlCommand(sql, connection);
            if (Convert.ToInt32(command.ExecuteScalar()) <= 0)
            {
                MessageBox.Show("科目" + oldname + "不存在！");
                return;
            }

            sql = "select count(*) from subject where sname = '" + newname + "'";
            command = new MySqlCommand(sql, connection);
            if (Convert.ToInt32(command.ExecuteScalar()) > 0)
            {
                MessageBox.Show("科目" + newname + "已存在！");
                return;
            }

            sql = "update subject set sname = '" + newname + "' where sname = '" + oldname + "'";
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("修改成功");

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
