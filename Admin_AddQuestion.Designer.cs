namespace 试题库管理系统
{
    partial class Admin_AddQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AddQuestion));
            this.subject = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.point = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(198, 174);
            this.subject.Margin = new System.Windows.Forms.Padding(4);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(124, 30);
            this.subject.TabIndex = 0;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(198, 253);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(124, 30);
            this.type.TabIndex = 1;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(449, 178);
            this.content.Margin = new System.Windows.Forms.Padding(4);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(538, 30);
            this.content.TabIndex = 2;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(449, 253);
            this.answer.Margin = new System.Windows.Forms.Padding(4);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(538, 30);
            this.answer.TabIndex = 3;
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(198, 339);
            this.point.Margin = new System.Windows.Forms.Padding(4);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(124, 30);
            this.point.TabIndex = 4;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(198, 418);
            this.value.Margin = new System.Windows.Forms.Padding(4);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(124, 30);
            this.value.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 339);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 109);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加题目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F);
            this.button3.Location = new System.Drawing.Point(802, 514);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 73);
            this.button3.TabIndex = 10;
            this.button3.Text = "返回上一级";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(95, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "科目：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(95, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "题型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(75, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "知识点：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(75, 428);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "难易度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(377, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "答案：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(339, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "题目描述：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(63, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 70);
            this.label7.TabIndex = 30;
            this.label7.Text = "试题添加";
            // 
            // Admin_AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.point);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.content);
            this.Controls.Add(this.type);
            this.Controls.Add(this.subject);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_AddQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.TextBox point;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}