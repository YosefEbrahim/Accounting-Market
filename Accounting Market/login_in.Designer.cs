namespace WindowsFormsApplication5
{
    partial class user
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
			this.txtuser_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtuser_name
			// 
			this.txtuser_name.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtuser_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtuser_name.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txtuser_name.Location = new System.Drawing.Point(56, 65);
			this.txtuser_name.Margin = new System.Windows.Forms.Padding(4);
			this.txtuser_name.Multiline = true;
			this.txtuser_name.Name = "txtuser_name";
			this.txtuser_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtuser_name.Size = new System.Drawing.Size(396, 32);
			this.txtuser_name.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(512, 65);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "اسم المستخدم";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Location = new System.Drawing.Point(565, 153);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 33);
			this.label2.TabIndex = 4;
			this.label2.Text = "كلمه السر";
			// 
			// txt_password
			// 
			this.txt_password.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_password.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txt_password.Location = new System.Drawing.Point(56, 152);
			this.txt_password.Margin = new System.Windows.Forms.Padding(4);
			this.txt_password.Name = "txt_password";
			this.txt_password.PasswordChar = '*';
			this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_password.Size = new System.Drawing.Size(396, 34);
			this.txt_password.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Gold;
			this.label3.Location = new System.Drawing.Point(254, 9);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(204, 33);
			this.label3.TabIndex = 5;
			this.label3.Text = "تسجيل الدخول";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(239, 234);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 42);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(6, 153);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(43, 35);
			this.button2.TabIndex = 6;
			this.button2.Text = "*";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// user
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(736, 321);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_password);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtuser_name);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "user";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "مرحبا";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
	}
}

