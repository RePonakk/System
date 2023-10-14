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
using NPOI.XWPF.UserModel;

namespace 试题库管理系统
{
    public partial class Admin_AddUser : Form
    {
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;
        Form reform;
        public Admin_AddUser(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acc = txt_account.Text;
            string pas = txt_password.Text;
            string repas = txt_repassword.Text; 
            if (acc != "" && pas != "" && repas != "")
            {
                if (pas == repas)
                {
                    builder.UserID = "root";//用户
                    builder.Password = "123456";//密码
                    builder.Server = "localhost";
                    builder.Database = "test_database";//数据库名
                    connection = new MySqlConnection(builder.ConnectionString);
                    connection.Open();

                    string sql = "select * from user where account = '" + acc + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("该用户已存在！");
                    }
                    else
                    {
                        sql = "insert into user(account, password) VALUES ('" + acc + "', '" + pas + "');";
                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("添加成功");
                    }

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("两次密码不一样请重新输入！");
                }
            }
            else
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
