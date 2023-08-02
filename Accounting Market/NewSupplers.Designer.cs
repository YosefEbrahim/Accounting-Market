
namespace WindowsFormsApplication5
{
	partial class NewSupplers
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_name_sh = new System.Windows.Forms.TextBox();
			this.txt_phone_sh = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.supplersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.supplerDataSet = new WindowsFormsApplication5.SupplerDataSet();
			this.btnDel = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.txt_notes = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_add = new System.Windows.Forms.TextBox();
			this.txt_phone = new System.Windows.Forms.TextBox();
			this.btn_clear = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_comp = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_del_picture = new System.Windows.Forms.Button();
			this.supplersTableAdapter = new WindowsFormsApplication5.SupplerDataSetTableAdapters.SupplersTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.supplersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.supplerDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(1019, 285);
			this.txt_email.Multiline = true;
			this.txt_email.Name = "txt_email";
			this.txt_email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_email.Size = new System.Drawing.Size(329, 34);
			this.txt_email.TabIndex = 100;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(1357, 285);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(171, 29);
			this.label1.TabIndex = 99;
			this.label1.Text = "البريد الالكترونى :";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.BurlyWood;
			this.panel1.Controls.Add(this.txt_name_sh);
			this.panel1.Controls.Add(this.txt_phone_sh);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Location = new System.Drawing.Point(30, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(456, 375);
			this.panel1.TabIndex = 98;
			// 
			// txt_name_sh
			// 
			this.txt_name_sh.Location = new System.Drawing.Point(6, 124);
			this.txt_name_sh.Margin = new System.Windows.Forms.Padding(6);
			this.txt_name_sh.Multiline = true;
			this.txt_name_sh.Name = "txt_name_sh";
			this.txt_name_sh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_name_sh.Size = new System.Drawing.Size(329, 34);
			this.txt_name_sh.TabIndex = 9;
			this.txt_name_sh.TextChanged += new System.EventHandler(this.txt_name_sh_TextChanged);
			this.txt_name_sh.Leave += new System.EventHandler(this.txt_name_sh_Leave);
			// 
			// txt_phone_sh
			// 
			this.txt_phone_sh.Location = new System.Drawing.Point(6, 214);
			this.txt_phone_sh.Margin = new System.Windows.Forms.Padding(6);
			this.txt_phone_sh.Multiline = true;
			this.txt_phone_sh.Name = "txt_phone_sh";
			this.txt_phone_sh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_phone_sh.Size = new System.Drawing.Size(329, 34);
			this.txt_phone_sh.TabIndex = 7;
			this.txt_phone_sh.TextChanged += new System.EventHandler(this.txt_phone_sh_TextChanged);
			this.txt_phone_sh.Leave += new System.EventHandler(this.txt_phone_sh_Leave);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Gold;
			this.label11.Location = new System.Drawing.Point(188, 37);
			this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(87, 38);
			this.label11.TabIndex = 10;
			this.label11.Text = "البحث";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Black;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Gold;
			this.label12.Location = new System.Drawing.Point(347, 124);
			this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label12.Name = "label12";
			this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label12.Size = new System.Drawing.Size(104, 29);
			this.label12.TabIndex = 11;
			this.label12.Text = "اسم المورد";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Black;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Gold;
			this.label13.Location = new System.Drawing.Point(351, 216);
			this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label13.Size = new System.Drawing.Size(105, 29);
			this.label13.TabIndex = 12;
			this.label13.Text = "رقم الهاتف";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8});
			this.dataGridView1.DataSource = this.supplersBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Location = new System.Drawing.Point(-7, 478);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowHeadersWidth = 50;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowTemplate.Height = 35;
			this.dataGridView1.Size = new System.Drawing.Size(1541, 573);
			this.dataGridView1.TabIndex = 97;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// supplersBindingSource
			// 
			this.supplersBindingSource.DataMember = "Supplers";
			this.supplersBindingSource.DataSource = this.supplerDataSet;
			// 
			// supplerDataSet
			// 
			this.supplerDataSet.DataSetName = "SupplerDataSet";
			this.supplerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.Color.DarkKhaki;
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.Location = new System.Drawing.Point(1131, 381);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(103, 36);
			this.btnDel.TabIndex = 95;
			this.btnDel.Text = "حذف";
			this.btnDel.UseVisualStyleBackColor = false;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.BackColor = System.Drawing.Color.DarkKhaki;
			this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Add.Location = new System.Drawing.Point(1355, 382);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(105, 35);
			this.btn_Add.TabIndex = 94;
			this.btn_Add.Text = "اضافه";
			this.btn_Add.UseVisualStyleBackColor = false;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// btn_save
			// 
			this.btn_save.BackColor = System.Drawing.Color.DarkKhaki;
			this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_save.Location = new System.Drawing.Point(1243, 381);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(103, 36);
			this.btn_save.TabIndex = 93;
			this.btn_save.Text = "تعديل";
			this.btn_save.UseVisualStyleBackColor = false;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// txt_notes
			// 
			this.txt_notes.Location = new System.Drawing.Point(1019, 219);
			this.txt_notes.Multiline = true;
			this.txt_notes.Name = "txt_notes";
			this.txt_notes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_notes.Size = new System.Drawing.Size(329, 34);
			this.txt_notes.TabIndex = 92;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Location = new System.Drawing.Point(517, 242);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(329, 169);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 91;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(1019, 87);
			this.txt_name.Multiline = true;
			this.txt_name.Name = "txt_name";
			this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_name.Size = new System.Drawing.Size(329, 34);
			this.txt_name.TabIndex = 90;
			// 
			// txt_add
			// 
			this.txt_add.Location = new System.Drawing.Point(1019, 153);
			this.txt_add.Multiline = true;
			this.txt_add.Name = "txt_add";
			this.txt_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_add.Size = new System.Drawing.Size(329, 34);
			this.txt_add.TabIndex = 89;
			// 
			// txt_phone
			// 
			this.txt_phone.Location = new System.Drawing.Point(517, 96);
			this.txt_phone.Multiline = true;
			this.txt_phone.Name = "txt_phone";
			this.txt_phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_phone.Size = new System.Drawing.Size(329, 34);
			this.txt_phone.TabIndex = 88;
			// 
			// btn_clear
			// 
			this.btn_clear.BackColor = System.Drawing.Color.DarkKhaki;
			this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clear.Location = new System.Drawing.Point(1019, 381);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(103, 36);
			this.btn_clear.TabIndex = 96;
			this.btn_clear.Text = "تنظيف";
			this.btn_clear.UseVisualStyleBackColor = false;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Gold;
			this.label7.Location = new System.Drawing.Point(859, 240);
			this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(142, 29);
			this.label7.TabIndex = 87;
			this.label7.Text = "صوره المورد :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Gold;
			this.label6.Location = new System.Drawing.Point(859, 92);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(112, 29);
			this.label6.TabIndex = 86;
			this.label6.Text = "رقم الهاتف:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Gold;
			this.label5.Location = new System.Drawing.Point(1382, 219);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(106, 29);
			this.label5.TabIndex = 85;
			this.label5.Text = "ملاحظات :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Gold;
			this.label8.Location = new System.Drawing.Point(1382, 87);
			this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(118, 29);
			this.label8.TabIndex = 84;
			this.label8.Text = "اسم المورد :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Gold;
			this.label9.Location = new System.Drawing.Point(1382, 153);
			this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label9.Size = new System.Drawing.Size(87, 29);
			this.label9.TabIndex = 83;
			this.label9.Text = "العنوان :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Desktop;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Gold;
			this.label10.Location = new System.Drawing.Point(1074, 5);
			this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 38);
			this.label10.TabIndex = 82;
			this.label10.Text = "المورديين";
			// 
			// txt_comp
			// 
			this.txt_comp.Location = new System.Drawing.Point(517, 171);
			this.txt_comp.Multiline = true;
			this.txt_comp.Name = "txt_comp";
			this.txt_comp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_comp.Size = new System.Drawing.Size(329, 34);
			this.txt_comp.TabIndex = 102;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gold;
			this.label2.Location = new System.Drawing.Point(859, 167);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(129, 29);
			this.label2.TabIndex = 101;
			this.label2.Text = " اسم الشركة :";
			// 
			// btn_del_picture
			// 
			this.btn_del_picture.BackColor = System.Drawing.Color.DarkKhaki;
			this.btn_del_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_del_picture.Location = new System.Drawing.Point(592, 427);
			this.btn_del_picture.Name = "btn_del_picture";
			this.btn_del_picture.Size = new System.Drawing.Size(190, 36);
			this.btn_del_picture.TabIndex = 103;
			this.btn_del_picture.Text = "حذف الصورة";
			this.btn_del_picture.UseVisualStyleBackColor = false;
			this.btn_del_picture.Click += new System.EventHandler(this.btn_del_picture_Click);
			// 
			// supplersTableAdapter
			// 
			this.supplersTableAdapter.ClearBeforeFill = true;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "اسم المورد";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "address";
			this.dataGridViewTextBoxColumn3.HeaderText = "العنوان";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Notes";
			this.dataGridViewTextBoxColumn4.HeaderText = "ملاحظات";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
			this.dataGridViewTextBoxColumn5.HeaderText = "رقم الهاتف";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "company";
			this.dataGridViewTextBoxColumn6.HeaderText = "الشركة";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "email";
			this.dataGridViewTextBoxColumn7.HeaderText = "البريد";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "isActive";
			this.dataGridViewCheckBoxColumn1.HeaderText = "isActive";
			this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn1.Width = 125;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Image";
			this.dataGridViewTextBoxColumn8.HeaderText = "الصورة";
			this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// NewSupplers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1532, 1037);
			this.Controls.Add(this.btn_del_picture);
			this.Controls.Add(this.txt_comp);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.txt_notes);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.txt_add);
			this.Controls.Add(this.txt_phone);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximizeBox = false;
			this.Name = "NewSupplers";
			this.Text = "NewSupplers";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.NewSupplers_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.supplersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.supplerDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_name_sh;
		private System.Windows.Forms.TextBox txt_phone_sh;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.TextBox txt_notes;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_add;
		private System.Windows.Forms.TextBox txt_phone;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_comp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_del_picture;
		private SupplerDataSet supplerDataSet;
		private System.Windows.Forms.BindingSource supplersBindingSource;
		private SupplerDataSetTableAdapters.SupplersTableAdapter supplersTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
	}
}