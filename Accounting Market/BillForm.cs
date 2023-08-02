using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.db;

namespace WindowsFormsApplication5
{
	public partial class BillForm : Form
	{
		SalesEntities db = new SalesEntities();
		public BillForm()
		{
			InitializeComponent();
		}

		private void BillForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'listproductDataSet.product' table. You can move, or remove it, as needed.
			this.productTableAdapter.Fill(this.listproductDataSet.product);
			// TODO: This line of code loads data into the 'billDataSet.Customer' table. You can move, or remove it, as needed.
			//this.customerTableAdapter.Fill(this.billDataSet.Customer);
			this.customerTableAdapter.FillBy(this.billDataSet.Customer);


		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedValue == null)
			{
				return;
			}
			else
			{
				var result = db.products.SingleOrDefault(n => n.id == (int)listBox1.SelectedValue);
				txt_name_pro.Text = result.Name;
				txt_price_unit.Text = result.Price.ToString();
			}

		}
		private void CalcToltal()
		{
			decimal total = 0;
			for (int i = 0; i < dataGridView1.RowCount; i++)
			{
				total += decimal.Parse(dataGridView1.Rows[i].Cells["price_for_all"].Value.ToString());

			}
			lbl_total.Text = total.ToString();
		}
		private void btn_add_Click(object sender, EventArgs e)
		{
			if (txt_num_qty.Text != "")
			{
				var result = db.products.SingleOrDefault(n => n.id == (int)listBox1.SelectedValue);
				for (int i = 0; i < dataGridView1.RowCount; i++)
				{
					if (dataGridView1.Rows[i].Cells["id"].Value.ToString() == result.id.ToString())
					{
						dataGridView1.Rows[i].Cells["qauntity"].Value = int.Parse(dataGridView1.Rows[i].Cells["qauntity"].Value.ToString()) + int.Parse(txt_num_qty.Text);
						dataGridView1.Rows[i].Cells["price_for_all"].Value = int.Parse(dataGridView1.Rows[i].Cells["qauntity"].Value.ToString()) * result.Price;
						CalcToltal();
						return;
					}
				}
				dataGridView1.Rows.Add(result.id, result.Name, result.Price, txt_num_qty.Text, result.Price * decimal.Parse(txt_num_qty.Text));
				CalcToltal();
				result.Quantity = result.Quantity - int.Parse(txt_num_qty.Text);
				db.SaveChanges();
				txt_num_qty.Clear();
				dataGridView1.ClearSelection();
			}
			else
				MessageBox.Show("يجب ادخال عددالمنتج");
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			for (int i = 0; i < dataGridView1.RowCount; i++)
			{
				int result = int.Parse(dataGridView1.CurrentRow.Cells["qauntity"].Value.ToString());
				txt_num_qty.Text = result.ToString();
			}
		}

		private void btn_del_Click(object sender, EventArgs e)
		{

			decimal total = decimal.Parse(lbl_total.Text);
			total -= decimal.Parse(dataGridView1.CurrentRow.Cells["price_for_all"].Value.ToString());
			lbl_total.Text = total.ToString();
			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
			dataGridView1.ClearSelection();
		}

		private void txt_sh_TextChanged(object sender, EventArgs e)
		{
			listBox1.DataSource = db.products.Where(n => n.Name.Contains(txt_sh.Text)).ToList();
		}

		private void btn_mod_Click(object sender, EventArgs e)
		{
			if (txt_num_qty.Text != "")
			{
				var dec = int.Parse(dataGridView1.CurrentRow.Cells["qauntity"].Value.ToString());
				var inc = int.Parse(txt_num_qty.Text);
				var idRes = dataGridView1.CurrentRow.Cells["id"].Value;
				var result = db.products.SingleOrDefault(n => n.id == (int)idRes);
				dataGridView1.CurrentRow.Cells["qauntity"].Value = txt_num_qty.Text;
				dataGridView1.CurrentRow.Cells["price_for_all"].Value = int.Parse(dataGridView1.CurrentRow.Cells["qauntity"].Value.ToString()) * result.Price;
				if (inc > dec)
				{
					result.Quantity = result.Quantity - (int.Parse(txt_num_qty.Text) - dec);
				}
				else
				{
					result.Quantity = result.Quantity + (dec - int.Parse(txt_num_qty.Text));
				}
				db.SaveChanges();
				CalcToltal();
				dataGridView1.ClearSelection();
				return;
			}
		}
	}
}
