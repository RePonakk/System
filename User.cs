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
using MySql.Data.MySqlClient;

namespace 试题库管理系统
{
    public partial class User : Form
    {
        
        public User()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string acc = txt_account.Text;
            string pas = txt_password.Text;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();//与数据库连接的信息
            MySqlConnection connection;//定义与数据连接的链接
            builder.UserID = "root";//用户
            builder.Password = "123456";//密码
            builder.Server = "localhost";
            builder.Database = "test_database";//数据库名
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();


            if (acc != "" && pas != "")
            {
                string sql = "select count(*) from user where account ='" + acc + "'and password ='" + pas + "'";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                if (Convert.ToInt32(cmd.ExecuteScalar()) >= 1) //ExecuteScalar 返回结果的第一行第一列
                {
                    MessageBox.Show("登录成功");

                    User_Menu user_menu = new User_Menu(acc);

                    user_menu.Visible = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }

                connection.Close();
            }
            else
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }

            
        }

        
    }
    
}
