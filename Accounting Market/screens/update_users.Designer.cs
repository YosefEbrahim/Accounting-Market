namespace WindowsFormsApplication5.screens
{
	partial class update_users
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txt_user_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.btn_update = new System.Windows.Forms.Button();
			this.txt_search = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userDataSet = new WindowsFormsApplication5.UserDataSet();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_del_picture = new System.Windows.Forms.Button();
			this.usersTableAdapter = new WindowsFormsApplication5.UserDataSetTableAdapters.UsersTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_user_name
			// 
			this.txt_user_name.Location = new System.Drawing.Point(643, 87);
			this.txt_user_name.Name = "txt_user_name";
			this.txt_user_name.Size = new System.Drawing.Size(425, 41);
			this.txt_user_name.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(1143, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "اسم المستخدم :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Gold;
			this.label2.Location = new System.Drawing.Point(1143, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 36);
			this.label2.TabIndex = 4;
			this.label2.Text = "كلمه المرور :";
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(643, 169);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Size = new System.Drawing.Size(425, 41);
			this.txt_pass.TabIndex = 3;
			// 
			// btn_update
			// 
			this.btn_update.BackColor = System.Drawing.Color.DarkKhaki;
			this.btn_update.Location = new System.Drawing.Point(387, 172);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(183, 44);
			this.btn_update.TabIndex = 6;
			this.btn_update.Text = "تعديل";
			this.btn_update.UseVisualStyleBackColor = false;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// txt_search
			// 
			this.txt_search.Location = new System.Drawing.Point(14, 17);
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(425, 41);
			this.txt_search.TabIndex = 7;
			this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.ForeColor = System.Drawing.Color.Gold;
			this.label3.Location = new System.Drawing.Point(509, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 36);
			this.label3.TabIndex = 8;
			this.label3.Text = "ابحث الان :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.ForeColor = System.Drawing.Color.Gold;
			this.label4.Location = new System.Drawing.Point(577, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 36);
			this.label4.TabIndex = 9;
			this.label4.Text = "تعديل مستخدم";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Gold;
			this.label5.Location = new System.Drawing.Point(151, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 36);
			this.label5.TabIndex = 11;
			this.label5.Text = "الصوره";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(38, 67);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(317, 196);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.dataGridView1.DataSource = this.usersBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.GridColor = System.Drawing.Color.Gray;
			this.dataGridView1.Location = new System.Drawing.Point(2, 327);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.RowHeadersWidth = 50;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowTemplate.Height = 35;
			this.dataGridView1.Size = new System.Drawing.Size(1329, 383);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// usersBindingSource
			// 
			this.usersBindingSource.DataMember = "Users";
			this.usersBindingSource.DataSource = this.userDataSet;
			// 
			// userDataSet
			// 
			this.userDataSet.DataSetName = "UserDataSet";
			this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.Color.DarkKhaki;
			this.btnDel.Location = new System.Drawing.Point(387, 244);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(183, 44);
			this.btnDel.TabIndex = 12;
			this.btnDel.Text = "حذف";
			this.btnDel.UseVisualStyleBackColor = false;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.DarkKhaki;
			this.btnAdd.Location = new System.Drawing.Point(387, 88);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(183, 44);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "اضافه";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.BurlyWood;
			this.panel1.Controls.Add(this.txt_search);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(643, 244);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(663, 72);
			this.panel1.TabIndex = 14;
			// 
			// btn_del_picture
			// 
			this.btn_del_picture.BackColor = System.Drawing.Color.DarkKhaki;
			this.btn_del_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_del_picture.Location = new System.Drawing.Point(111, 280);
			this.btn_del_picture.Name = "btn_del_picture";
			this.btn_del_picture.Size = new System.Drawing.Size(190, 36);
			this.btn_del_picture.TabIndex = 40;
			this.btn_del_picture.Text = "حذف الصورة";
			this.btn_del_picture.UseVisualStyleBackColor = false;
			this.btn_del_picture.Click += new System.EventHandler(this.btn_del_picture_Click);
			// 
			// usersTableAdapter
			// 
			this.usersTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
			this.dataGridViewTextBoxColumn2.HeaderText = "اسم المستخدم";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
			this.dataGridViewTextBoxColumn3.HeaderText = "كلمة المرور";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Image";
			this.dataGridViewTextBoxColumn4.HeaderText = "الصورة";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// update_users
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(1330, 710);
			this.Controls.Add(this.btn_del_picture);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_user_name);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(7);
			this.MaximizeBox = false;
			this.Name = "update_users";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نعديل مستخدم";
			this.Load += new System.EventHandler(this.update_users_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txt_user_name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.TextBox txt_search;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_del_picture;
		private UserDataSet userDataSet;
		private System.Windows.Forms.BindingSource usersBindingSource;
		private UserDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
	}
}