namespace WindowsFormsApp1
{
    partial class Admin_AddQuestions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AddQuestions));
            this.txt_question = new System.Windows.Forms.TextBox();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.btn_question = new System.Windows.Forms.Button();
            this.btn_answer = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.subject = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_question
            // 
            this.txt_question.Location = new System.Drawing.Point(21, 115);
            this.txt_question.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.Size = new System.Drawing.Size(532, 25);
            this.txt_question.TabIndex = 0;
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(21, 159);
            this.txt_answer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.ReadOnly = true;
            this.txt_answer.Size = new System.Drawing.Size(532, 25);
            this.txt_answer.TabIndex = 1;
            // 
            // btn_question
            // 
            this.btn_question.Location = new System.Drawing.Point(581, 113);
            this.btn_question.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_question.Name = "btn_question";
            this.btn_question.Size = new System.Drawing.Size(113, 27);
            this.btn_question.TabIndex = 2;
            this.btn_question.Text = "选择试题文档";
            this.btn_question.UseVisualStyleBackColor = true;
            this.btn_question.Click += new System.EventHandler(this.btn_question_Click);
            // 
            // btn_answer
            // 
            this.btn_answer.Location = new System.Drawing.Point(581, 157);
            this.btn_answer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_answer.Name = "btn_answer";
            this.btn_answer.Size = new System.Drawing.Size(113, 27);
            this.btn_answer.TabIndex = 3;
            this.btn_answer.Text = "选择答案文档";
            this.btn_answer.UseVisualStyleBackColor = true;
            this.btn_answer.Click += new System.EventHandler(this.btn_answer_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("宋体", 12F);
            this.btnImport.Location = new System.Drawing.Point(425, 220);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(128, 52);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.SystemColors.Window;
            this.subject.Location = new System.Drawing.Point(240, 231);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(129, 25);
            this.subject.TabIndex = 5;
            this.subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 12F);
            this.button6.Location = new System.Drawing.Point(546, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 55);
            this.button6.TabIndex = 24;
            this.button6.Text = "返回菜单";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(25, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "预导入试题所属科目：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(45, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(456, 70);
            this.label7.TabIndex = 31;
            this.label7.Text = "试题批量导入";
            // 
            // Admin_AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 400);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btn_answer);
            this.Controls.Add(this.btn_question);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.txt_question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Admin_AddQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量添加题目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Button btn_question;
        private System.Windows.Forms.Button btn_answer;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}