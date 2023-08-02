namespace WindowsFormsApplication5
{
	partial class main_Form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_Form));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.عرضالمستحدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.النواقصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.العملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.الموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.الفاتورهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labal1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.lblTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblDate = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.العملاءToolStripMenuItem,
            this.الموردينToolStripMenuItem,
            this.الفاتورهToolStripMenuItem,
            this.التقاريرToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1030, 36);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
			this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
			this.fileToolStripMenuItem.Text = "ملف";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Image = global::WindowsFormsApplication5.Properties.Resources.close_window;
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
			this.closeToolStripMenuItem.Text = "اغلاق";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالمستحدمينToolStripMenuItem});
			this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
			this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(138, 32);
			this.usersToolStripMenuItem.Text = "المستخدم";
			// 
			// عرضالمستحدمينToolStripMenuItem
			// 
			this.عرضالمستحدمينToolStripMenuItem.Image = global::WindowsFormsApplication5.Properties.Resources._11;
			this.عرضالمستحدمينToolStripMenuItem.Name = "عرضالمستحدمينToolStripMenuItem";
			this.عرضالمستحدمينToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
			this.عرضالمستحدمينToolStripMenuItem.Text = "ادارة  المستحدمين";
			this.عرضالمستحدمينToolStripMenuItem.Click += new System.EventHandler(this.عرضالمستحدمينToolStripMenuItem_Click);
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductToolStripMenuItem,
            this.النواقصToolStripMenuItem});
			this.productsToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
			this.productsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productsToolStripMenuItem.Image")));
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(129, 32);
			this.productsToolStripMenuItem.Text = "المنتجات";
			// 
			// manageProductToolStripMenuItem
			// 
			this.manageProductToolStripMenuItem.Image = global::WindowsFormsApplication5.Properties.Resources.new_by_copy__v2;
			this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
			this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
			this.manageProductToolStripMenuItem.Text = "اداره المنتجات";
			this.manageProductToolStripMenuItem.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
			// 
			// النواقصToolStripMenuItem
			// 
			this.النواقصToolStripMenuItem.Image = global::WindowsFormsApplication5.Properties.Resources.checkout;
			this.النواقصToolStripMenuItem.Name = "النواقصToolStripMenuItem";
			this.النواقصToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
			this.النواقصToolStripMenuItem.Text = "النواقص";
			// 
			// العملاءToolStripMenuItem
			// 
			this.العملاءToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
			this.العملاءToolStripMenuItem.Image = global::WindowsFormsApplication5.Properties.Resources.gender_neutral_user;
			this.العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
			this.العملاءToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
			this.العملاءToolStripMenuItem.Text = "العملاء";
			this.العملاءToolStripMenuItem.Click += new System.EventHandler(this.العملاءToolStripMenuItem_Click);
			// 
			// الموردينToolStripMenuItem
			// 
			this.الموردينToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
			this.الموردينToolStripMenuItem.Image = global::WindowsFormsApplication5.Properties.Resources.customer_insight;
			this.الموردينToolStripMenuItem.Name = "الموردينToolStripMenuItem";
			this.الموردينToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
			this.الموردينToolStripMenuItem.Text = "الموردين";
			this.الموردينToolStripMenuItem.Click += new System.EventHandler(this.الموردينToolStripMenuItem_Click);
			// 
			// الفاتورهToolStripMenuItem
			// 
			this.الفاتورهToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
			this.الفاتورهToolStripMenuItem.Image = global::WindowsFormsApplication5.Properties.Resources.receipt;
			this.الفاتورهToolStripMenuItem.Name = "الفاتورهToolStripMenuItem";
			this.الفاتورهToolStripMenuItem.Size = new System.Drawing.Size(116, 32);
			this.الفاتورهToolStripMenuItem.Text = "الفاتوره";
			// 
			// التقاريرToolStripMenuItem
			// 
			this.التقاريرToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
			this.التقاريرToolStripMenuItem.Image = global::WindowsFormsApplication5.Properties.Resources.add_receipt;
			this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
			this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
			this.التقاريرToolStripMenuItem.Text = "التقارير";
			// 
			// labal1
			// 
			this.labal1.AutoSize = true;
			this.labal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labal1.ForeColor = System.Drawing.Color.Gold;
			this.labal1.Location = new System.Drawing.Point(818, 243);
			this.labal1.Name = "labal1";
			this.labal1.Size = new System.Drawing.Size(65, 25);
			this.labal1.TabIndex = 10;
			this.labal1.Text = "الفواتير";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(522, 243);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 25);
			this.label1.TabIndex = 11;
			this.label1.Text = "العملاء";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gold;
			this.label2.Location = new System.Drawing.Point(199, 243);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 25);
			this.label2.TabIndex = 12;
			this.label2.Text = "الموردين";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Gold;
			this.label3.Location = new System.Drawing.Point(818, 479);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 25);
			this.label3.TabIndex = 13;
			this.label3.Text = "المشتريات";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Gold;
			this.label4.Location = new System.Drawing.Point(522, 479);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 25);
			this.label4.TabIndex = 14;
			this.label4.Text = "المبيعات";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Gold;
			this.label5.Location = new System.Drawing.Point(199, 479);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 25);
			this.label5.TabIndex = 15;
			this.label5.Text = "المنتجات";
			this.label5.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Transparent;
			this.button6.Image = global::WindowsFormsApplication5.Properties.Resources.shop;
			this.button6.Location = new System.Drawing.Point(147, 288);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(176, 176);
			this.button6.TabIndex = 9;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Transparent;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Transparent;
			this.button5.Image = global::WindowsFormsApplication5.Properties.Resources.checkout;
			this.button5.Location = new System.Drawing.Point(467, 288);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(176, 176);
			this.button5.TabIndex = 8;
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Transparent;
			this.button3.Image = global::WindowsFormsApplication5.Properties.Resources.new_by_copy__v2;
			this.button3.Location = new System.Drawing.Point(760, 55);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(176, 174);
			this.button3.TabIndex = 7;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Transparent;
			this.button4.Image = global::WindowsFormsApplication5.Properties.Resources.group_task;
			this.button4.Location = new System.Drawing.Point(147, 55);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(173, 174);
			this.button4.TabIndex = 4;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.الموردينToolStripMenuItem_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Transparent;
			this.button2.Image = global::WindowsFormsApplication5.Properties.Resources.new_product;
			this.button2.Location = new System.Drawing.Point(760, 288);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(176, 176);
			this.button2.TabIndex = 2;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Image = global::WindowsFormsApplication5.Properties.Resources.user_male;
			this.button1.Location = new System.Drawing.Point(467, 55);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(173, 174);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.العملاءToolStripMenuItem_Click);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.Location = new System.Drawing.Point(754, 537);
			this.lblTime.Name = "lblTime";
			this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTime.Size = new System.Drawing.Size(135, 32);
			this.lblTime.TabIndex = 16;
			this.lblTime.Text = "00:00:00";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(147, 537);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(135, 32);
			this.lblDate.TabIndex = 17;
			this.lblDate.Text = "1/1/2000";
			// 
			// main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(1030, 589);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labal1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Navy;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "main_Form";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "الرئسية";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem العملاءToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem الموردينToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem الفاتورهToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label labal1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripMenuItem عرضالمستحدمينToolStripMenuItem;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.ToolStripMenuItem النواقصToolStripMenuItem;
	}
}