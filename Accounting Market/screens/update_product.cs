using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.db;

namespace WindowsFormsApplication5.screens
{
	public partial class update_product : Form
	{
		string image_path = "";
		SalesEntities db = new SalesEntities();
		public update_product()
		{
			InitializeComponent();
		}
		private void ClearAll()
		{
			txt_code.Text = txt_name.Text = txt_notes.Text = txt_price.Text = txt_qty.Text = string.Empty;
			pictureBox1.ImageLocation = "";
			comboBox1.Text = "";
		}
		private void txt_nprodt_TextChanged_1(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.products.Where(y => y.Name.Contains(txt_nprodt.Text)).ToList();
		}

		private void txt_codeprodt_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.products.Where(x => x.Code.Contains(txt_codeprodt.Text)).ToList();
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			var result = db.products.SingleOrDefault(x => x.id == index);
			txt_code.Text = result.Code;
			txt_name.Text = result.Name;
			txt_price.Text = result.Price.ToString();
			txt_qty.Text = result.Quantity.ToString();
			txt_notes.Text = result.Notes;
			pictureBox1.ImageLocation = result.Image;
			comboBox1.SelectedValue = result.CategoryId;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			if (op.ShowDialog() == DialogResult.OK)
			{
				image_path = op.FileName;
				pictureBox1.ImageLocation = op.FileName;
			}
		}

		private void txt_codeprodt_Leave(object sender, EventArgs e)
		{
			txt_codeprodt.Clear();
			dataGridView1.DataSource = db.products.ToList();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (txt_code.Text == string.Empty && txt_name.Text == string.Empty && txt_notes.Text == string.Empty && txt_price.Text == string.Empty && txt_qty.Text == string.Empty)
			{
				MessageBox.Show("لا يوجد شئ لتعديله ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (comboBox1.Text == "")
			{
				MessageBox.Show("يجب اختيار فئة المنتج");
			}
			else
			{
				int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
				var result = db.products.SingleOrDefault(x => x.id == index);
				result.Name = txt_name.Text;
				result.Price = decimal.Parse(txt_price.Text);
				result.Quantity = int.Parse(txt_qty.Text);
				result.Notes = txt_notes.Text;
				result.Code = txt_code.Text;
				result.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());

				if (pictureBox1.ImageLocation != "")
				{
					image_path = pictureBox1.ImageLocation;

					if (Directory.Exists(Environment.CurrentDirectory + "\\images\\Product\\"))
					{
						if (File.Exists(Environment.CurrentDirectory + "\\images\\Product\\" + result.id + ".jpg"))
						{
							File.Delete(Environment.CurrentDirectory + "\\images\\Product\\" + result.id + ".jpg");
							string newimage = Environment.CurrentDirectory + "\\images\\Product\\" + result.id + ".jpg";
							File.Copy(image_path, newimage);
							result.Image = newimage;
						}
						else
						{
							string newimage = Environment.CurrentDirectory + "\\images\\Product\\" + result.id + ".jpg";
							File.Copy(image_path, newimage);
							result.Image = newimage;
						}
					}
					else
					{
						Directory.CreateDirectory(Environment.CurrentDirectory + "\\images\\Product\\");
						string newimage = Environment.CurrentDirectory + "\\images\\Product\\" + result.id + ".jpg";
						File.Copy(image_path, newimage);
						result.Image = newimage;
					}

				}
				MessageBox.Show("تم التعديل");
				db.SaveChanges();
				dataGridView1.DataSource = db.products.ToList();
				dataGridView1.ClearSelection();
				ClearAll();
			}

		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			if (txt_name.Text == "" && txt_code.Text == "")
			{
				MessageBox.Show("يجب ادخال اسم المنتج و كود المنتج ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (comboBox1.Text == "")
			{
				MessageBox.Show("يجب اختيار فئة المنتج");
			}
			else
			{

				product pd = new product();
				pd.Code = txt_code.Text;
				pd.Name = txt_name.Text;
				pd.Notes = txt_notes.Text;
				pd.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
				try
				{
					pd.Price = decimal.Parse(txt_price.Text);
					pd.Quantity = int.Parse(txt_qty.Text);
				}
				catch (Exception)
				{
					throw new Exception("ادخل قيمه صحيحه مثل 12");
				}

				if (pictureBox1.ImageLocation != "")
				{
					image_path = pictureBox1.ImageLocation;
					if (Directory.Exists(Environment.CurrentDirectory + "\\images\\Product\\"))
					{
						if (File.Exists(Environment.CurrentDirectory + "\\images\\Product\\" + pd.id + ".jpg"))
						{
							File.Delete(Environment.CurrentDirectory + "\\images\\Product\\" + pd.id + ".jpg");
							string newimage = Environment.CurrentDirectory + "\\images\\Product\\" + pd.id + ".jpg";
							File.Copy(image_path, newimage);
							pd.Image = newimage;
						}
						else
						{
							string newimage = Environment.CurrentDirectory + "\\images\\Product\\" + pd.id + ".jpg";
							File.Copy(image_path, newimage);
							pd.Image = newimage;
						}
					}
					else
					{
						Directory.CreateDirectory(Environment.CurrentDirectory + "\\images\\Product\\");
						string newimage = Environment.CurrentDirectory + "\\images\\Product\\" + pd.id + ".jpg";
						File.Copy(image_path, newimage);
						pd.Image = newimage;
					}

				}
				db.products.Add(pd);
				db.SaveChanges();
				MessageBox.Show("تم اضافه المنتج بنجاح");
				dataGridView1.DataSource = db.products.ToList();
				dataGridView1.ClearSelection();
				ClearAll();
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			var r = MessageBox.Show("هل تريد الحذف", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (r == DialogResult.Yes)
			{
				int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
				var result = db.products.SingleOrDefault(x => x.id == index);
				db.products.Remove(result);
				db.SaveChanges();
				dataGridView1.DataSource = db.products.ToList();
				MessageBox.Show("تم الحذف بنجاح");
			}
			dataGridView1.ClearSelection();
			ClearAll();
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			ClearAll();

		}

		private void btn_del_picture_Click(object sender, EventArgs e)
		{
			pictureBox1.ImageLocation = "";
		}

		private void update_product_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'productDataSet2.product' table. You can move, or remove it, as needed.
			this.productTableAdapter2.Fill(this.productDataSet2.product);
			// TODO: This line of code loads data into the 'categoryDataSet.Category' table. You can move, or remove it, as needed.
			this.categoryTableAdapter.Fill(this.categoryDataSet.Category);
			comboBox1.Text = "";
			comboBox2.Text = "";

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox2.SelectedValue == null)
			{
				return;
			}
			else
			{
				int catid = int.Parse(comboBox2.SelectedValue.ToString());
				dataGridView1.DataSource = db.products.Where(p => p.CategoryId == catid).ToList();

			}
		}

		private void btn_dis_Click(object sender, EventArgs e)
		{
			comboBox2.Text = "";
			dataGridView1.DataSource = db.products.ToList();
			dataGridView1.ClearSelection();
		}

		private void btn_Up_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.products.ToList();
			dataGridView1.ClearSelection();
		}
	}
}
