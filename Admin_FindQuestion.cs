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
    public partial class Admin_FindQuestion : Form
    {
        Form reform;

        public Admin_FindQuestion(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            MySqlConnection connection;
            MySqlDataAdapter adapter;
            string sql;
            MySqlCommand command;

            builder.UserID = "root";//用户
            builder.Password = "123456";//密码
            builder.Server = "localhost";
            builder.Database = "test_database";//数据库名
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();


            if (string.IsNullOrEmpty(txt_subject.Text) || string.IsNullOrEmpty(txt_point.Text) || string.IsNullOrEmpty(txt_type.Text) || string.IsNullOrEmpty(txt_value.Text) )
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }


            sql = "select content from question where";
            int sum = 0;
            if (txt_subject.Text != "")
            {
                sql += " sname = '" + txt_subject.Text + "' and";
                sum++;
            }

            if (txt_point.Text != "")
            {
                sql += " pname = '" + txt_point.Text + "' and";
                sum++;
            }

            if (txt_type.Text != "")
            {
                sql += " type = '" + txt_type.Text + "' and";
                sum++;
            }

            if (txt_value.Text != "")
            {
                sql += " value = '" + txt_value.Text + "' and";
                sum++;
            }

            if(sum > 0)
            {
                sql = sql.Substring(0, sql.Length - 4);
            }
            else
            {
                sql = sql.Substring(0, sql.Length - 6);
            }

            command = new MySqlCommand(sql, connection);
            adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            string str=null;
            string x;
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                x = row["content"].ToString();
                x = x.Substring(2, x.Length - 3);
                str += (x + "\n\n");
            }

            MessageBox.Show(str);

            connection.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}
