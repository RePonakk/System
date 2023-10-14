namespace 试题库管理系统
{
    partial class Admin_ChangePoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_ChangePoint));
            this.txt_newpoint = new System.Windows.Forms.TextBox();
            this.txt_oldsubject = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_oldpoint = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_newpoint
            // 
            this.txt_newpoint.Location = new System.Drawing.Point(264, 261);
            this.txt_newpoint.Name = "txt_newpoint";
            this.txt_newpoint.Size = new System.Drawing.Size(190, 25);
            this.txt_newpoint.TabIndex = 28;
            // 
            // txt_oldsubject
            // 
            this.txt_oldsubject.Location = new System.Drawing.Point(264, 132);
            this.txt_oldsubject.Name = "txt_oldsubject";
            this.txt_oldsubject.Size = new System.Drawing.Size(190, 25);
            this.txt_oldsubject.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F);
            this.button2.Location = new System.Drawing.Point(559, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 82);
            this.button2.TabIndex = 26;
            this.button2.Text = "确认修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(69, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "知识点名称：";
            // 
            // txt_oldpoint
            // 
            this.txt_oldpoint.Location = new System.Drawing.Point(264, 196);
            this.txt_oldpoint.Name = "txt_oldpoint";
            this.txt_oldpoint.Size = new System.Drawing.Size(190, 25);
            this.txt_oldpoint.TabIndex = 24;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 12F);
            this.button5.Location = new System.Drawing.Point(624, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 55);
            this.button5.TabIndex = 29;
            this.button5.Text = "返回上一级";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(61, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 70);
            this.label7.TabIndex = 34;
            this.label7.Text = "知识点修改";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(69, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "知识点所属科目：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(69, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "修改后知识点名称：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Admin_ChangePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_newpoint);
            this.Controls.Add(this.txt_oldsubject);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_oldpoint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_ChangePoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_ChangePoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_newpoint;
        private System.Windows.Forms.TextBox txt_oldsubject;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_oldpoint;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}