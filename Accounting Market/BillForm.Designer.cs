
namespace WindowsFormsApplication5
{
	partial class BillForm
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.billDataSet = new WindowsFormsApplication5.BillDataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.customerTableAdapter = new WindowsFormsApplication5.BillDataSetTableAdapters.CustomerTableAdapter();
			this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.listproductDataSet = new WindowsFormsApplication5.listproductDataSet();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.qauntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price_for_all = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productTableAdapter = new WindowsFormsApplication5.listproductDataSetTableAdapters.productTableAdapter();
			this.txt_num_qty = new System.Windows.Forms.TextBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_name_pro = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_price_unit = new System.Windows.Forms.TextBox();
			this.btn_mod = new System.Windows.Forms.Button();
			this.btn_del = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.lbl_total = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_sh = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billDataSet)).BeginInit();
			this.fillByToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.listproductDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(1159, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox1.Size = new System.Drawing.Size(232, 34);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 26);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox2.Size = new System.Drawing.Size(615, 37);
			this.textBox2.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 87);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateTimePicker1.Size = new System.Drawing.Size(615, 34);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "id", true));
			this.comboBox1.DataSource = this.customerBindingSource;
			this.comboBox1.DisplayMember = "Name";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(761, 26);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.comboBox1.Size = new System.Drawing.Size(269, 37);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.ValueMember = "id";
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.billDataSet;
			// 
			// billDataSet
			// 
			this.billDataSet.DataSetName = "BillDataSet";
			this.billDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(1397, 29);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(128, 29);
			this.label1.TabIndex = 4;
			this.label1.Text = "رقم الفاتورة :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Gold;
			this.label2.Location = new System.Drawing.Point(1036, 29);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(79, 29);
			this.label2.TabIndex = 5;
			this.label2.Text = "العميل :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Gold;
			this.label3.Location = new System.Drawing.Point(633, 31);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label3.Size = new System.Drawing.Size(106, 29);
			this.label3.TabIndex = 6;
			this.label3.Text = "ملاحظات :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Gold;
			this.label4.Location = new System.Drawing.Point(635, 87);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(87, 29);
			this.label4.TabIndex = 7;
			this.label4.Text = "التاريخ :";
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// fillByToolStripButton
			// 
			this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fillByToolStripButton.Name = "fillByToolStripButton";
			this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
			this.fillByToolStripButton.Text = "FillBy";
			// 
			// fillByToolStrip
			// 
			this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
			this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
			this.fillByToolStrip.Name = "fillByToolStrip";
			this.fillByToolStrip.Size = new System.Drawing.Size(1537, 27);
			this.fillByToolStrip.TabIndex = 8;
			this.fillByToolStrip.Text = "fillByToolStrip";
			this.fillByToolStrip.Visible = false;
			// 
			// listBox1
			// 
			this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "id", true));
			this.listBox1.DataSource = this.productBindingSource;
			this.listBox1.DisplayMember = "Name";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 29;
			this.listBox1.Location = new System.Drawing.Point(1129, 365);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(376, 410);
			this.listBox1.TabIndex = 9;
			this.listBox1.ValueMember = "id";
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataMember = "product";
			this.productBindingSource.DataSource = this.listproductDataSet;
			// 
			// listproductDataSet
			// 
			this.listproductDataSet.DataSetName = "listproductDataSet";
			this.listproductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.qauntity,
            this.price_for_all});
			this.dataGridView1.Location = new System.Drawing.Point(12, 363);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1065, 412);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// id
			// 
			this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.HeaderText = "name";
			this.name.MinimumWidth = 6;
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// price
			// 
			this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.price.HeaderText = "price";
			this.price.MinimumWidth = 6;
			this.price.Name = "price";
			this.price.ReadOnly = true;
			// 
			// qauntity
			// 
			this.qauntity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.qauntity.HeaderText = "qauntity";
			this.qauntity.MinimumWidth = 6;
			this.qauntity.Name = "qauntity";
			this.qauntity.ReadOnly = true;
			// 
			// price_for_all
			// 
			this.price_for_all.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.price_for_all.HeaderText = "price for all";
			this.price_for_all.MinimumWidth = 6;
			this.price_for_all.Name = "price_for_all";
			this.price_for_all.ReadOnly = true;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// txt_num_qty
			// 
			this.txt_num_qty.Location = new System.Drawing.Point(688, 238);
			this.txt_num_qty.Name = "txt_num_qty";
			this.txt_num_qty.Size = new System.Drawing.Size(171, 34);
			this.txt_num_qty.TabIndex = 12;
			// 
			// btn_add
			// 
			this.btn_add.BackColor = System.Drawing.Color.Goldenrod;
			this.btn_add.ForeColor = System.Drawing.Color.Black;
			this.btn_add.Location = new System.Drawing.Point(441, 304);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(133, 47);
			this.btn_add.TabIndex = 13;
			this.btn_add.Text = "اضافه";
			this.btn_add.UseVisualStyleBackColor = false;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Gold;
			this.label5.Location = new System.Drawing.Point(865, 238);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(143, 29);
			this.label5.TabIndex = 14;
			this.label5.Text = " عدد الوحدات :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Gold;
			this.label6.Location = new System.Drawing.Point(553, 239);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(120, 29);
			this.label6.TabIndex = 16;
			this.label6.Text = " اسم المنتج :";
			// 
			// txt_name_pro
			// 
			this.txt_name_pro.BackColor = System.Drawing.Color.Linen;
			this.txt_name_pro.Enabled = false;
			this.txt_name_pro.ForeColor = System.Drawing.Color.White;
			this.txt_name_pro.Location = new System.Drawing.Point(376, 239);
			this.txt_name_pro.Name = "txt_name_pro";
			this.txt_name_pro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_name_pro.Size = new System.Drawing.Size(171, 34);
			this.txt_name_pro.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label7.ForeColor = System.Drawing.Color.Gold;
			this.label7.Location = new System.Drawing.Point(214, 65);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(144, 29);
			this.label7.TabIndex = 18;
			this.label7.Text = " السعر للوحده :";
			// 
			// txt_price_unit
			// 
			this.txt_price_unit.BackColor = System.Drawing.Color.Linen;
			this.txt_price_unit.Enabled = false;
			this.txt_price_unit.ForeColor = System.Drawing.Color.White;
			this.txt_price_unit.Location = new System.Drawing.Point(12, 64);
			this.txt_price_unit.Name = "txt_price_unit";
			this.txt_price_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_price_unit.Size = new System.Drawing.Size(196, 34);
			this.txt_price_unit.TabIndex = 17;
			// 
			// btn_mod
			// 
			this.btn_mod.BackColor = System.Drawing.Color.Goldenrod;
			this.btn_mod.ForeColor = System.Drawing.Color.Black;
			this.btn_mod.Location = new System.Drawing.Point(584, 304);
			this.btn_mod.Name = "btn_mod";
			this.btn_mod.Size = new System.Drawing.Size(133, 47);
			this.btn_mod.TabIndex = 19;
			this.btn_mod.Text = "تعديل";
			this.btn_mod.UseVisualStyleBackColor = false;
			this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
			// 
			// btn_del
			// 
			this.btn_del.BackColor = System.Drawing.Color.Goldenrod;
			this.btn_del.ForeColor = System.Drawing.Color.Black;
			this.btn_del.Location = new System.Drawing.Point(298, 304);
			this.btn_del.Name = "btn_del";
			this.btn_del.Size = new System.Drawing.Size(133, 47);
			this.btn_del.TabIndex = 20;
			this.btn_del.Text = "حذف";
			this.btn_del.UseVisualStyleBackColor = false;
			this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.WindowText;
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txt_price_unit);
			this.groupBox1.ForeColor = System.Drawing.Color.SpringGreen;
			this.groupBox1.Location = new System.Drawing.Point(12, 173);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox1.Size = new System.Drawing.Size(1065, 184);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "تعديل الفاتورة";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Gold;
			this.label8.Location = new System.Drawing.Point(237, 31);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(121, 36);
			this.label8.TabIndex = 22;
			this.label8.Text = "الاجمالى :";
			// 
			// lbl_total
			// 
			this.lbl_total.AutoSize = true;
			this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_total.ForeColor = System.Drawing.Color.Gold;
			this.lbl_total.Location = new System.Drawing.Point(88, 31);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_total.Size = new System.Drawing.Size(60, 36);
			this.lbl_total.TabIndex = 23;
			this.lbl_total.Text = "0.0";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Controls.Add(this.lbl_total);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Location = new System.Drawing.Point(1126, 173);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(379, 100);
			this.panel1.TabIndex = 24;
			// 
			// txt_sh
			// 
			this.txt_sh.Location = new System.Drawing.Point(1126, 310);
			this.txt_sh.Name = "txt_sh";
			this.txt_sh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_sh.Size = new System.Drawing.Size(254, 34);
			this.txt_sh.TabIndex = 25;
			this.txt_sh.TextChanged += new System.EventHandler(this.txt_sh_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Gold;
			this.label9.Location = new System.Drawing.Point(1414, 307);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label9.Size = new System.Drawing.Size(94, 36);
			this.label9.TabIndex = 24;
			this.label9.Text = "البحث :";
			// 
			// BillForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1537, 843);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txt_sh);
			this.Controls.Add(this.btn_del);
			this.Controls.Add(this.btn_mod);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_name_pro);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.txt_num_qty);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.fillByToolStrip);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximizeBox = false;
			this.Name = "BillForm";
			this.Text = "BillForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.BillForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billDataSet)).EndInit();
			this.fillByToolStrip.ResumeLayout(false);
			this.fillByToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.listproductDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private BillDataSet billDataSet;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private BillDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
		private System.Windows.Forms.ToolStripButton fillByToolStripButton;
		private System.Windows.Forms.ToolStrip fillByToolStrip;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private listproductDataSet listproductDataSet;
		private System.Windows.Forms.BindingSource productBindingSource;
		private listproductDataSetTableAdapters.productTableAdapter productTableAdapter;
		private System.Windows.Forms.TextBox txt_num_qty;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_name_pro;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_price_unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn qauntity;
		private System.Windows.Forms.DataGridViewTextBoxColumn price_for_all;
		private System.Windows.Forms.Button btn_mod;
		private System.Windows.Forms.Button btn_del;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbl_total;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_sh;
		private System.Windows.Forms.Label label9;
	}
}