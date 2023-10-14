using Microsoft.Office.Interop.Word;
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
using static 试题库管理系统.User_AddSinglePaper;
using Word = Microsoft.Office.Interop.Word;
namespace 试题库管理系统
{
    public partial class User_AddSinglePaper : Form
    {
        public double Check(string str1, string str2)
        {
            int[,] dp = new int[500, 500];
            int len1 = str1.Length;
            int len2 = str2.Length;

            if (str1[0] == str2[0])
            {
                dp[0, 0] = 1;
            }
            else
            {
                dp[0, 0] = 0;
            }

            for (int i = 1; i < len1; i++)
            {
                for (int j = 1; j < len2; j++)
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

            return dp[len1 - 1, len2 - 1] * 1.0 / len1;
        }

        Form reform;

        List<string> point= new List<string>();
        List<string> type = new List<string>();
        List<int> number = new List<int>();

        public User_AddSinglePaper(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nowpoint = txt_point.Text;
            point.Add(nowpoint);
            lbl_point.Text += nowpoint + "\n";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nowtype = txt_type.Text;
            string nownumber = txt_typenumber.Text;

            type.Add(nowtype);
            number.Add(Convert.ToInt32(nownumber));

            lbl_type.Text += nowtype + " " + nownumber + "\n";
        }

        public class Question {
            public string content;
            public string answer;
            public int value;
            public bool flag;
            public string point;
            public string type;
            public Question(string content, string answer, int value, string point, string type)
            {
                this.content = content;
                this.answer = answer;
                this.value = value;
                this.flag = true;
                this.point = point;
                this.type = type;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<Question> question = new List<Question>();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            MySqlConnection connection;//定义与数据连接的链接
            MySqlDataAdapter adapter;
            string sql;
            MySqlCommand command;

            builder.UserID = "root";//用户
            builder.Password = "123456";//密码
            builder.Server = "localhost";
            builder.Database = "test_database";//数据库名
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            
            sql = "select * from question";
            command = new MySqlCommand(sql, connection);

            adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                bool flag = true;
                string x = row["content"].ToString();
                foreach(string t in content)
                {
                    if(Check(t,x)>=0.75)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Question ques = new Question(row["content"].ToString(), row["answer"].ToString(), Convert.ToInt32(row["value"].ToString()), row["pname"].ToString(), row["type"].ToString());
                    question.Add( ques );
                }
            }

            connection.Close();

            

            Random random = new Random();
            int sum = 0;
            foreach (int t in number)
            {
                sum += t;

            }

            int now = 0;
            int sumvalue = 0;
            for (int i = 0; i < point.Count; i++)
            {
                bool flag = true;
                while (flag)
                {
                    int x = random.Next(0,question.Count);

                    int index = type.IndexOf(question[x].type);

                    if (index != -1 && number[index]>0 && question[x].flag)
                    {
                        number[index]--;
                        now++;
                        question[x].flag = false;
                        flag = false;
                        sumvalue += question[x].value;
                    }
                }
            }

            int value = Convert.ToInt32(txt_value.Text);
            double nowvalue = (value * sum - sumvalue)*1.0 / now;

            while (now<sum)
            {
                int x = random.Next(0, question.Count);

                if()
            }
        }

        List<string> content = new List<string>();
        private void btn_doc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word 文档 (*.docx;*.doc)|*.docx;*.doc";
            openFileDialog.ShowDialog();

            string filename = openFileDialog.FileName;
            lbl_doc.Text += "\n" + filename;

            Word.Application wordApp = new Word.Application();
            Word.Document questionsDoc = wordApp.Documents.Open(filename);

            
            string nowcontent = null;

            foreach (Word.Paragraph questionParagraph in questionsDoc.Paragraphs) // 遍历试题文档中的每个段落
            {
                
                if (questionParagraph.Range.Font.Bold != -1)
                {
                    if (questionParagraph.Range.ListFormat.ListValue > 0)
                    {
                        if (nowcontent != null)
                        {
                            nowcontent = "/*" + nowcontent + "*/";
                            content.Add(nowcontent);
                        }
                        nowcontent = questionParagraph.Range.Text.Trim();
                    }
                    else
                    {
                        nowcontent += questionParagraph.Range.Text.Trim();
                    }
                }

            }
            nowcontent = "/*" + nowcontent + "*/";
            content.Add(nowcontent);

            questionsDoc.Close();
            wordApp.Quit();



        }
    }
}
