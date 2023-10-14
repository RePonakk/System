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
using Microsoft.Office.Interop.Word;
namespace 试题库管理系统
{
    public partial class Admin_AddQuestion : Form
    {
        //str1和str2的最大子串占str1的百分比
        public double Check(string str1,string str2)
        {
            int[,] dp = new int[500, 500];
            int len1=str1.Length;
            int len2=str2.Length;

            if (str1[0] == str2[0])
            {
                dp[0, 0] = 1;
            }
            else
            {
                dp[0, 0] = 0;
            }

            for(int i = 1; i < len1; i++)
            {
                for(int j = 1; j < len2; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[len1 - 1, len2 - 1]*1.0 / len1;
        }

        Form reform;
        public Admin_AddQuestion(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

     

        private void button1_Click_1(object sender, EventArgs e)
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

            if (subject.Text != "" && point.Text != "" && value.Text != "" && content.Text != "" && answer.Text != ""   )
            {
                sql = "select content from question";
                command = new MySqlCommand(sql, connection);
                adapter = new MySqlDataAdapter(command);

                DataSet ds = new DataSet();
                adapter.Fill(ds);


                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string x = row["content"].ToString();
                    if (Check(x, content.Text) >= 0.75)
                    {
                        MessageBox.Show("题库中有相似题目");
                        return;
                    }
                }

                sql = "select MAX(qid) from question";
                command = new MySqlCommand(sql, connection);

                int qid = Convert.ToInt32(command.ExecuteScalar()) + 1;

                try
                {
                    sql = "INSERT INTO question (sname,pname,type,content,answer,value,qid) VALUES ('" + subject.Text + "', '" + point.Text + "', '" + type.Text + "', '" + content.Text + "', '" + answer.Text + "', '" + value.Text + "', '" + qid.ToString() + "');";
                    command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("添加成功");
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1452)
                    {
                        MessageBox.Show("不存在该科目或知识点");
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }

      
    }
}
