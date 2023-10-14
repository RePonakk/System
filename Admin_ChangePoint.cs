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

namespace 试题库管理系统
{
    public partial class Admin_ChangePoint : Form
    {
        Form reform;
        public Admin_ChangePoint(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oldsubject = txt_oldsubject.Text;
            string oldpoint = txt_oldpoint.Text;
            string newpoint = txt_newpoint.Text;

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

            if (string.IsNullOrEmpty(oldpoint) || string.IsNullOrEmpty(oldsubject) || string.IsNullOrEmpty(newpoint))
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }

            if (oldpoint == newpoint)
            {
                MessageBox.Show("修改后知识点名称不能和原来名称一样！"+'\n'+"请重新输入！");
                return;
            }

            sql = "select count(*) from point where sname = '" + oldsubject + "'";
            command = new MySqlCommand(sql, connection);

            if (Convert.ToInt32(command.ExecuteScalar()) <= 0)
            {
                MessageBox.Show("科目 " + oldsubject + " 不存在");
                return;
            }

            sql = "select count(*) from point where sname = '" + oldsubject + "' and pname = '" + oldpoint + "'";
            command = new MySqlCommand(sql, connection);

            if (Convert.ToInt32(command.ExecuteScalar()) <= 0)
            {
                MessageBox.Show("科目" + oldsubject + "没有知识点" + oldpoint);
                return;
            }

            sql = "select count(*) from point where sname = '" + oldsubject + "' and pname = '" + newpoint + "'";
            command = new MySqlCommand(sql, connection);

            if (Convert.ToInt32(command.ExecuteScalar()) > 0)
            {
                MessageBox.Show("科目" + oldsubject + "已经包含知识点" + newpoint);
                return;
            }

            sql = "update point set pname = '" + newpoint + "' where sname = '" + oldsubject + "' and pname = '" + oldpoint + "'";
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("修改知识点成功！");
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();

        }

      
    }
}
