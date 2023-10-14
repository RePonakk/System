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
    public partial class Admin_DropPoint : Form
    {
        Form reform;
        public Admin_DropPoint(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dropsubject = txt_dropsubject.Text;
            string droppoint = txt_droppoint.Text;

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

            if (string.IsNullOrEmpty(droppoint) || string.IsNullOrEmpty(dropsubject))
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }

            sql = "select count(*) from point where sname = '" + dropsubject + "'";
            command = new MySqlCommand(sql, connection);

            if (Convert.ToInt32(command.ExecuteScalar()) <= 0)
            {
                MessageBox.Show("科目 " + dropsubject + " 不存在");
                return;
            }

            sql = "select count(*) from point where sname = '" + dropsubject + "' and pname = '" + droppoint + "'";
            command = new MySqlCommand(sql, connection);

            if (Convert.ToInt32(command.ExecuteScalar()) <= 0)
            {
                MessageBox.Show("科目" + dropsubject + "没有知识点" + droppoint);
                return;
            }

            try
            {
                sql = "delete from point where sname = '" + dropsubject + "' and pname = '" + droppoint + "'";
                command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("删除成功");
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("该知识点下有题目存在，不能删除");
                }
            }

            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
