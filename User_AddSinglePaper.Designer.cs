namespace 试题库管理系统
{
    partial class User_AddSinglePaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_AddSinglePaper));
            this.button6 = new System.Windows.Forms.Button();
            this.txt_papername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_point = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_point = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_typenumber = new System.Windows.Forms.TextBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_doc = new System.Windows.Forms.Button();
            this.lbl_doc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 12F);
            this.button6.Location = new System.Drawing.Point(631, 372);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 55);
            this.button6.TabIndex = 26;
            this.button6.Text = "返回上一级";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_papername
            // 
            this.txt_papername.Location = new System.Drawing.Point(115, 75);
            this.txt_papername.Name = "txt_papername";
            this.txt_papername.Size = new System.Drawing.Size(100, 25);
            this.txt_papername.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "添加知识点";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.Location = new System.Drawing.Point(42, 264);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(97, 15);
            this.lbl_point.TabIndex = 29;
            this.lbl_point.Text = "当前知识点：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "试卷名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "试卷难度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "题型类型：";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(405, 98);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(100, 25);
            this.txt_type.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "添加题型";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_point
            // 
            this.txt_point.Location = new System.Drawing.Point(45, 303);
            this.txt_point.Name = "txt_point";
            this.txt_point.Size = new System.Drawing.Size(100, 25);
            this.txt_point.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "题型题目个数：";
            // 
            // txt_typenumber
            // 
            this.txt_typenumber.Location = new System.Drawing.Point(673, 98);
            this.txt_typenumber.Name = "txt_typenumber";
            this.txt_typenumber.Size = new System.Drawing.Size(100, 25);
            this.txt_typenumber.TabIndex = 37;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(276, 44);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(82, 15);
            this.lbl_type.TabIndex = 39;
            this.lbl_type.Text = "当前题型：";
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(115, 157);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(100, 25);
            this.txt_value.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "组卷";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_doc
            // 
            this.btn_doc.Location = new System.Drawing.Point(342, 303);
            this.btn_doc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_doc.Name = "btn_doc";
            this.btn_doc.Size = new System.Drawing.Size(163, 27);
            this.btn_doc.TabIndex = 43;
            this.btn_doc.Text = "选择历年试题文档";
            this.btn_doc.UseVisualStyleBackColor = true;
            this.btn_doc.Click += new System.EventHandler(this.btn_doc_Click);
            // 
            // lbl_doc
            // 
            this.lbl_doc.AutoSize = true;
            this.lbl_doc.Location = new System.Drawing.Point(339, 229);
            this.lbl_doc.Name = "lbl_doc";
            this.lbl_doc.Size = new System.Drawing.Size(112, 15);
            this.lbl_doc.TabIndex = 44;
            this.lbl_doc.Text = "历年文档路径：";
            // 
            // User_AddSinglePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_doc);
            this.Controls.Add(this.btn_doc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_typenumber);
            this.Controls.Add(this.txt_point);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_papername);
            this.Controls.Add(this.button6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_AddSinglePaper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_AddSinglePaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_papername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_point;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_typenumber;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_doc;
        private System.Windows.Forms.Label lbl_doc;
    }
}