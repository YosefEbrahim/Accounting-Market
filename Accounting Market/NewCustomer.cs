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

namespace WindowsFormsApplication5
{
	public partial class NewCustomer : Form
	{
		string image_path = "";
		SalesEntities db = new SalesEntities();
		public NewCustomer()
		{
			InitializeComponent();
		}
		private void ClearAll()
		{
			txt_name.Text = txt_add.Text = txt_notes.Text = txt_email.Text = txt_phone.Text = string.Empty;
			pictureBox1.Image = null;
			rdo_btn.Checked = false;
			rdo_btn2.Checked = false;

		}

		private void txt_name_sh_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.Customers.Where(x => x.Name.Contains(txt_name_sh.Text)).ToList();
		}

		private void txt_phone_sh_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.Customers.Where(y => y.phone.Contains(txt_phone_sh.Text)).ToList();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			var result = db.Customers.SingleOrDefault(x => x.id == index);
			txt_name.Text = result.Name;
			txt_add.Text = result.address;
			txt_phone.Text = result.phone.ToString();
			txt_email.Text = result.email;
			txt_notes.Text = result.Notes;
			pictureBox1.ImageLocation = result.Image;
			if (result.isActive == true)
				rdo_btn.Checked = true;
			else
				rdo_btn2.Checked = false;

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

		private void txt_name_sh_Leave(object sender, EventArgs e)
		{
			txt_name_sh.Clear();
			dataGridView1.DataSource = db.Customers.ToList();
		}

		private void txt_phone_sh_Leave(object sender, EventArgs e)
		{
			txt_phone_sh.Clear();
			dataGridView1.DataSource = db.Customers.ToList();
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			ClearAll();
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if (txt_name.Text != "")
			{
				var r = MessageBox.Show("هل تريد الحذف", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (r == DialogResult.Yes)
				{
					int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
					var result = db.Customers.SingleOrDefault(x => x.id == index);
					db.Customers.Remove(result);
					db.SaveChanges();
					dataGridView1.DataSource = db.Customers.ToList();
					MessageBox.Show("تم الحذف بنجاح");
				}
			}
			else
			{
				MessageBox.Show("لا يوجد شئ للحذف", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}


			dataGridView1.ClearSelection();
			ClearAll();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (txt_phone.Text == string.Empty && txt_name.Text == string.Empty && txt_notes.Text == string.Empty && txt_add.Text == string.Empty && txt_email.Text == string.Empty)
			{
				MessageBox.Show("لا يوجد شئ لتعديله ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
				var result = db.Customers.SingleOrDefault(x => x.id == index);
				result.Name = txt_name.Text;
				result.phone = txt_phone.Text;
				result.address = txt_add.Text;
				result.Notes = txt_notes.Text;
				if (pictureBox1.ImageLocation != "")
				{
					image_path = pictureBox1.ImageLocation;
					if (Directory.Exists(Environment.CurrentDirectory + "\\images\\Customer\\"))
					{
						if (File.Exists(Environment.CurrentDirectory + "\\images\\Customer\\" + result.id + ".jpg"))
						{
							File.Delete(Environment.CurrentDirectory + "\\images\\Customer\\" + result.id + ".jpg");
							string newimage = Environment.CurrentDirectory + "\\images\\Customer\\" + result.id + ".jpg";
							File.Copy(image_path, newimage);
							result.Image = newimage;
						}
						else
						{
							string newimage = Environment.CurrentDirectory + "\\images\\Customer\\" + result.id + ".jpg";
							File.Copy(image_path, newimage);
							result.Image = newimage;
						}
					}
					else
					{
						Directory.CreateDirectory(Environment.CurrentDirectory + "\\images\\Customer\\");
						string newimage = Environment.CurrentDirectory + "\\images\\Customer\\" + result.id + ".jpg";
						File.Copy(image_path, newimage);
						result.Image = newimage;
					}

				}
				result.email = txt_email.Text;
				if (rdo_btn.Checked == true)
				{
					result.isActive = true;
				}
				else if (rdo_btn2.Checked == true)
				{
					result.isActive = false;
				}
				db.SaveChanges();
				dataGridView1.DataSource = db.Customers.ToList();
				dataGridView1.ClearSelection();
				ClearAll();
			}
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			Customer c = new Customer();
			if (pictureBox1.ImageLocation != "")
			{
				image_path = pictureBox1.ImageLocation;
				if (Directory.Exists(Environment.CurrentDirectory + "\\images\\Customer\\"))
				{
					if (File.Exists(Environment.CurrentDirectory + "\\images\\Customer\\" + c.id + ".jpg"))
					{
						File.Delete(Environment.CurrentDirectory + "\\images\\Customer\\" + c.id + ".jpg");
						string newimage = Environment.CurrentDirectory + "\\images\\Customer\\" + c.id + ".jpg";
						File.Copy(image_path, newimage);
						c.Image = newimage;
					}
					else
					{
						string newimage = Environment.CurrentDirectory + "\\images\\Customer\\" + c.id + ".jpg";
						File.Copy(image_path, newimage);
						c.Image = newimage;
					}
				}
				else
				{
					Directory.CreateDirectory(Environment.CurrentDirectory + "\\images\\Customer\\");
					string newimage = Environment.CurrentDirectory + "\\images\\Customer\\" + c.id + ".jpg";
					File.Copy(image_path, newimage);
					c.Image = newimage;
				}

			}
			if (txt_name.Text == "" && txt_phone.Text == "")
			{
				var r = MessageBox.Show("يجب ادخال الاسم و قم الهاتف", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{

				c.address = txt_add.Text;
				c.Name = txt_name.Text;
				c.email = txt_email.Text;
				c.Notes = txt_notes.Text;
				c.phone = txt_phone.Text;
				if (rdo_btn.Checked == true)
				{
					c.isActive = true;
				}
				else if (rdo_btn2.Checked == true)
				{
					c.isActive = false;
				}
				MessageBox.Show("تم اضافه العميل بنجاح");
				db.Customers.Add(c);
				db.SaveChanges();
				dataGridView1.DataSource = db.Customers.ToList();
			}

			dataGridView1.ClearSelection();
			ClearAll();

		}

		private void btn_del_picture_Click(object sender, EventArgs e)
		{
			pictureBox1.ImageLocation = "";
		}

		private void NewCustomer_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
			this.customerTableAdapter.Fill(this.customerDataSet.Customer);

		}
	}
}
