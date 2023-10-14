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
    public partial class Admin_AddPoint : Form
    {
        Form reform;
        public Admin_AddPoint(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addsubject = txt_addsubject.Text;
            string addpoint = txt_addpoint.Text;

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

            if (addpoint != "" && addsubject != "" )
            {
                sql = "select count(*) from point where sname = '" + addsubject + "' and pname = '" + addpoint + "'";
                command = new MySqlCommand(sql, connection);

                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("科目" + addsubject + "已存在知识点 " + addpoint);
                    return;
                }
                try
                {
                    sql = "INSERT INTO point (pname, sname) VALUES ('" + addpoint + "', '" + addsubject + "');";
                    command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("添加知识点成功！");
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1452)
                    {
                        MessageBox.Show("科目" + addsubject + "不存在，无法添加知识点，请输入存在的科目");
                    }
                }

                connection.Close();
            }
            else
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
