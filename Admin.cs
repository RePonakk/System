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
using ZstdSharp.Unsafe;

namespace 试题库管理系统
{
    public partial class Admin : Form
    {
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection connection;

        private Form returnform1 = null;
        public Admin(Form F)
        {
            InitializeComponent();
            this.returnform1 = F;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acc = txt_account.Text;
            string pas = txt_password.Text;

            builder.UserID = "root";//用户
            builder.Password = "123456";//密码
            builder.Server = "localhost";
            builder.Database = "test_database";//数据库名
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            if (acc != "" && pas != "")
            {
                string sql = "select * from admin where account ='" + acc + "'and password ='" + pas + "'";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                if (cmd.ExecuteScalar() != null) //ExecuteScalar 返回结果的第一行第一列
                {
                    MessageBox.Show("登录成功");

                    Admin_Menu admin_menu = new Admin_Menu();
                    admin_menu.Visible = true;
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }
                /*ExecuteScalar

                对于Update、insert、Delete语句执行成功是返回值为该命令所影响的行数，如果影响的行数是0，则返回值就是0；

                对于所有其他类型的语句，返回值为 - 1；

                如果发生回滚，返回值也为 - 1；

                如果执行异常，会返回报错信息*/


                connection.Close();


                

            }
            else
            {
                MessageBox.Show("账号或密码不能为空！");
                return;
            }


        }

    }

    

       
    

}
