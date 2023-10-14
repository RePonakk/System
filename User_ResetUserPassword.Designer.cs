namespace 试题库管理系统
{
    partial class User_ResetUserPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_ResetUserPassword));
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_renewpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.txt_oldpass = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(421, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(23, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "确认新密码：";
            // 
            // txt_renewpass
            // 
            this.txt_renewpass.Location = new System.Drawing.Point(181, 308);
            this.txt_renewpass.Name = "txt_renewpass";
            this.txt_renewpass.Size = new System.Drawing.Size(169, 25);
            this.txt_renewpass.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(63, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(63, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "旧密码：";
            // 
            // txt_newpass
            // 
            this.txt_newpass.Location = new System.Drawing.Point(181, 218);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Size = new System.Drawing.Size(169, 25);
            this.txt_newpass.TabIndex = 11;
            // 
            // txt_oldpass
            // 
            this.txt_oldpass.Location = new System.Drawing.Point(181, 135);
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.Size = new System.Drawing.Size(169, 25);
            this.txt_oldpass.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 12F);
            this.button6.Location = new System.Drawing.Point(631, 383);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 55);
            this.button6.TabIndex = 24;
            this.button6.Text = "返回上一级";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(36, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 70);
            this.label7.TabIndex = 45;
            this.label7.Text = "密码修改";
            // 
            // User_ResetUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_renewpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.txt_oldpass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_ResetUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_renewpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.TextBox txt_oldpass;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
    }
}