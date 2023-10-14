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
using MySql.Data;
namespace 试题库管理系统
{
    public partial class Admin_ResetUserPassword : Form
    {
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;
        Form reform;
        public Admin_ResetUserPassword(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acc = txt_account.Text;
            string newpas = txt_newpass.Text;
            string renewpas = txt_renewpass.Text;


            if (acc != "" && newpas != "" && renewpas != "")
            {

                if (newpas != renewpas)
                {
                    MessageBox.Show("两次输入密码不一样！");
                    return;
                }

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
                    sql = "update user set password = '" + newpas + "' where account = '" + acc + "'";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("该用户不存在！");
                }

                connection.Close();
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
