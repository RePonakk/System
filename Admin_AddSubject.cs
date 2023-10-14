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
    public partial class Admin_AddSubject : Form
    {
        Form reform;
        public Admin_AddSubject(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addname = txt_add.Text;
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

            if (string.IsNullOrEmpty(addname)) 
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }

            sql = "select count(*) from subject where sname = '" + addname + "'";
            command = new MySqlCommand(sql, connection);

            if (Convert.ToInt32(command.ExecuteScalar()) > 0)
            {
                MessageBox.Show("该科目已存在");
                return;
            }

            sql = "INSERT INTO subject (sname) VALUES ('" + addname + "');";
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("添加成功");

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
