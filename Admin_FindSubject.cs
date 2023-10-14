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
    public partial class Admin_FindSubject : Form
    {
        Form reform;
        public Admin_FindSubject(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            MySqlConnection connection;//定义与数据连接的链接
            MySqlCommand command;
            MySqlDataAdapter adapter;
            string sql;

            builder.UserID = "root";//用户
            builder.Password = "123456";//密码
            builder.Server = "localhost";
            builder.Database = "test_database";//数据库名
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            sql = "select * from subject";
            command = new MySqlCommand(sql, connection);
            adapter = new MySqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = false;


            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
