using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace 试题库管理系统
{
    public partial class User_ResetUserPassword : Form
    {
        Form reform;

        private MySqlConnectionStringBuilder newbuilder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;
        public User_ResetUserPassword(string acc, Form reform)
        {
            this.acc = acc;
            InitializeComponent();
            this.reform = reform;
        }
        private string acc;
        

        private void button1_Click_1(object sender, EventArgs e)
        {

            string oldpas = txt_oldpass.Text;
            string newpas = txt_newpass.Text;
            string renewpas = txt_renewpass.Text;

            newbuilder.UserID = "root";//用户
            newbuilder.Password = "123456";//密码
            newbuilder.Server = "localhost";
            newbuilder.Database = "test_database";//数据库名
            connection = new MySqlConnection(newbuilder.ConnectionString);
            connection.Open();

            if (txt_oldpass.Text != "" && txt_newpass.Text != "" && txt_renewpass.Text != "")
            {
                string sql = "select count(*) from user where account ='" + acc + "'and password ='" + oldpas + "'";
                MySqlCommand recmd = new MySqlCommand(sql, connection);
                if (Convert.ToInt32(recmd.ExecuteScalar()) == 0) //ExecuteScalar 返回结果的第一行第一列
                {
                    MessageBox.Show("旧密码输入错误！");
                    return;
                }
                else
                {
                    if (newpas != renewpas)
                    {
                        MessageBox.Show("两次输入密码不一样！");
                        return;
                    }
                    else
                    { 
                        sql = "select * from user where account = '" + acc + "'";
                        MySqlCommand cmd = new MySqlCommand(sql, connection);
                        cmd.ExecuteScalar();

                        sql = "update user set password = '" + newpas + "' where account = '" + acc + "'";
                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("修改成功");
                    }
                } 
            }
            else
            {
                MessageBox.Show("输入框内不能为空");
            }


            
            
         
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
