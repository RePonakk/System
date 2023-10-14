using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;
using MySql.Data;
using MySql.Data.MySqlClient;

using Word = Microsoft.Office.Interop.Word; // 引入 Microsoft.Office.Interop.Word 命名空间，并为其设置别名 Word

namespace WindowsFormsApp1
{
    public partial class Admin_AddQuestions : Form // 创建名为 Form1 的部分类，继承自基类 Form
    {
        Form reform;

        public Admin_AddQuestions(Form reform)
        {
            InitializeComponent();
            this.reform = reform;
        }

        private void btn_question_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word 文档 (*.docx;*.doc)|*.docx;*.doc";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_question.Text = openFileDialog.FileName;
            }
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word 文档 (*.docx;*.doc)|*.docx;*.doc";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_answer.Text = openFileDialog.FileName;
            }
        }



        private void uppoints()
        {


        }



        private void btnImport_Click(object sender, EventArgs e)
        {
            string questionsFile = txt_question.Text;
            string answersFile = txt_answer.Text;

            if (string.IsNullOrEmpty(questionsFile) || string.IsNullOrEmpty(answersFile) || string.IsNullOrEmpty(subject.Text)) // 检查试题文档和答案文档路径是否为空
            {
                MessageBox.Show("请先选择试题文档和答案文档！");
                return;
            }

            
            Word.Application wordApp = new Word.Application();
            Word.Document questionsDoc = wordApp.Documents.Open(questionsFile); // 打开试题文档
            Word.Document answersDoc = wordApp.Documents.Open(answersFile); // 打开答案文档

            ProcessDocuments(questionsDoc, answersDoc); // 处理试题文档和答案文档的逻辑

            questionsDoc.Close(); // 关闭试题文档
            answersDoc.Close(); // 关闭答案文档
            wordApp.Quit(); // 关闭 Word 应用程序

            MessageBox.Show("题目导入成功！"); // 弹出对话框提示用户题目导入成功
            
            
        }

        private void ProcessDocuments(Word.Document questionsDoc, Word.Document answersDoc)
        {
            List<string> question = new List<string>();
            List<string> type = new List<string>();
            string nowtype = null;
            string nowquestion = null;

            foreach (Word.Paragraph questionParagraph in questionsDoc.Paragraphs) // 遍历试题文档中的每个段落
            {
            //  MessageBox.Show(questionParagraph.Range.ListFormat.ListValue.ToString() +" "+ questionParagraph.Range.ListFormat.ListString);
                if (questionParagraph.Range.Font.Bold == -1)
                {
                    if (nowquestion != null)
                    {
                        nowquestion = "/*" + nowquestion + "*/";
                        question.Add(nowquestion);
                        type.Add(nowtype);
                        nowquestion = null;
                    }
                //    nowtype = questionParagraph.Range.Text.Trim().Substring(0, 3);

                    if (questionParagraph.Range.Text.Trim().Length >= 3)
                    {
                        nowtype = questionParagraph.Range.Text.Trim().Substring(0, 3);
                    }
                    else
                    {
                        nowtype = questionParagraph.Range.Text.Trim();
                    }
                }
                else { 
                    if(questionParagraph.Range.ListFormat.ListValue > 0)
                    {
                        if(nowquestion!=null) {
                            nowquestion = "/*" + nowquestion + "*/";
                            question.Add(nowquestion);
                            type.Add(nowtype);
                        }
                        nowquestion = questionParagraph.Range.Text.Trim();
                    }
                    else
                    {
                        nowquestion += questionParagraph.Range.Text.Trim();
                    }
                }
                
            }
            nowquestion = "/*" + nowquestion + "*/";
            question.Add(nowquestion);
            type.Add(nowtype);

            string str;
            string nowanswer = null;
            List<string> answer = new List<string>();
            foreach (Word.Paragraph answerParagraph in answersDoc.Paragraphs) // 遍历试题文档中的每个段落
            {
                if (answerParagraph.Range.Bold == -1)
                {
                    nowtype = answerParagraph.Range.Text.Substring(0, 3);
                    
                }
                else
                {
                    str=answerParagraph.Range.ListFormat.ListString +  answerParagraph.Range.Text;
                    for(int i=0;i<str.Length;i++)
                    {
                        if ( str[i] == '.' && (i==1 || nowtype == "选择题" || nowtype == "填空题") )
                        {
                            if(nowanswer != null)
                            {
                                nowanswer = nowanswer.Substring(0, nowanswer.Length - 2);
                                nowanswer = "/*" + nowanswer + "*/";
                                answer.Add(nowanswer);
                            }
                            
                            nowanswer = str[i + 1].ToString();
                            i++;
                            
                        }
                        else
                        {
                            if(nowanswer != null)
                            {
                                nowanswer += str[i].ToString();
                            }
                            
                        }
                    }
                }
                
            }
            nowanswer = "/*" + nowanswer + "*/";
            answer.Add(nowanswer);

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            MySqlConnection connection;//定义与数据连接的链接
            string sql;
            MySqlCommand command;

            builder.UserID = "root";//用户
            builder.Password = "123456";//密码
            builder.Server = "localhost";
            builder.Database = "test_database";//数据库名
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            sql = "SET FOREIGN_KEY_CHECKS=0";
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();


            for (int i= 0; i < answer.Count; i++)
            {
                /*    MessageBox.Show (type[i]);
                    MessageBox.Show (question[i]);
                    MessageBox.Show (answer[i]);*/

                sql = "select count(*) from question";
                command = new MySqlCommand(sql, connection);
                int qid = 300;
                if (Convert.ToInt32(command.ExecuteScalar()) >= 1)
                {
                    sql = "select MAX(qid) from question";
                    command = new MySqlCommand(sql, connection);
                    qid = Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
                

                
                sql = "INSERT INTO `test_database`.`question` (`sname`,`type`, `content`, `answer`, `qid`) VALUES ('"+subject.Text+"','" + type[i] +"',\"" +question[i]+  "\", \"" + answer[i] +"\", '"+qid+"');";
                command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }


            sql = "SET FOREIGN_KEY_CHECKS=1";
            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            reform.Show();
        }
    }
}