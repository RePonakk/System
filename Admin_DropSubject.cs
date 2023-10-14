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
    public partial class Admin_DropSubject : Form
    {
        Form reform;
        public Admin_DropSubject(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dropname = txt_drop.Text;

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

            sql = "select count(*) from subject where sname = '" + dropname + "'";
            command = new MySqlCommand(sql, connection);

            if (string.IsNullOrEmpty(dropname))
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }

            if (Convert.ToInt32(command.ExecuteScalar()) <= 0)
            {
                MessageBox.Show("该科目不存在");
                return;
            }
            try
            {
                sql = "delete from subject where sname = '" + dropname + "'";
                command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("该科目下已经有题目，不能删除该科目");
                }

            }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
