namespace 试题库管理系统
{
    partial class Admin_DropPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_DropPoint));
            this.txt_dropsubject = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_droppoint = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_dropsubject
            // 
            this.txt_dropsubject.Location = new System.Drawing.Point(240, 180);
            this.txt_dropsubject.Name = "txt_dropsubject";
            this.txt_dropsubject.Size = new System.Drawing.Size(116, 25);
            this.txt_dropsubject.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 12F);
            this.button4.Location = new System.Drawing.Point(410, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 73);
            this.button4.TabIndex = 28;
            this.button4.Text = "确认删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(65, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "知识点所属科目：";
            // 
            // txt_droppoint
            // 
            this.txt_droppoint.Location = new System.Drawing.Point(240, 252);
            this.txt_droppoint.Name = "txt_droppoint";
            this.txt_droppoint.Size = new System.Drawing.Size(116, 25);
            this.txt_droppoint.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 12F);
            this.button5.Location = new System.Drawing.Point(600, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 55);
            this.button5.TabIndex = 30;
            this.button5.Text = "返回上一级";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(57, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 70);
            this.label7.TabIndex = 36;
            this.label7.Text = "知识点删除";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(105, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "知识点名称：";
            // 
            // Admin_DropPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_dropsubject);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_droppoint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_DropPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_DropPoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dropsubject;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_droppoint;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}