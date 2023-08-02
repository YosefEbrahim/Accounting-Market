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
	public partial class NewSupplers : Form
	{
		string image_path = "";
		SalesEntities db = new SalesEntities();
		public NewSupplers()
		{
			InitializeComponent();
		}


		private void ClearAll()
		{
			txt_phone.Text = txt_name.Text = txt_notes.Text = txt_comp.Text = txt_add.Text = txt_email.Text = string.Empty;
			pictureBox1.ImageLocation = "";
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			Suppler sp = new Suppler();
			if (txt_name.Text == "" && txt_phone.Text == "")
			{
				MessageBox.Show("يجب ادخال اسم المورد و رقم الهاتف ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{


				sp.address = txt_add.Text;
				sp.Name = txt_name.Text;
				sp.company = txt_comp.Text;
				sp.Notes = txt_notes.Text;
				sp.email = txt_email.Text;
				sp.phone = txt_phone.Text;
				if (pictureBox1.ImageLocation != "")
				{
					image_path = pictureBox1.ImageLocation;
					if (Directory.Exists(Environment.CurrentDirectory + "\\images\\Suppler\\"))
					{
						if (File.Exists(Environment.CurrentDirectory + "\\images\\Suppler\\" + sp.id + ".jpg"))
						{
							File.Delete(Environment.CurrentDirectory + "\\images\\Suppler\\" + sp.id + ".jpg");
							string newimage = Environment.CurrentDirectory + "\\images\\Suppler\\" + sp.id + ".jpg";
							File.Copy(image_path, newimage);
							sp.Image = newimage;
						}
						else
						{
							string newimage = Environment.CurrentDirectory + "\\images\\Suppler\\" + sp.id + ".jpg";
							File.Copy(image_path, newimage);
							sp.Image = newimage;
						}
					}
					else
					{
						Directory.CreateDirectory(Environment.CurrentDirectory + "\\images\\Suppler\\");
						string newimage = Environment.CurrentDirectory + "\\images\\Suppler\\" + sp.id + ".jpg";
						File.Copy(image_path, newimage);
						sp.Image = newimage;
					}

				}
				db.Supplers.Add(sp);
				db.SaveChanges();
				MessageBox.Show("تم اضافه المورد بنجاح");

			}

			dataGridView1.DataSource = db.Supplers.ToList();
			dataGridView1.ClearSelection();
			ClearAll();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			var result = db.Supplers.SingleOrDefault(x => x.id == index);
			txt_add.Text = result.address;
			txt_name.Text = result.Name;
			txt_comp.Text = result.company;
			txt_email.Text = result.email;
			txt_notes.Text = result.Notes;
			txt_phone.Text = result.phone;
			pictureBox1.ImageLocation = result.Image;

		}

		private void txt_name_sh_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.Supplers.Where(y => y.Name.Contains(txt_name_sh.Text)).ToList();
		}

		private void txt_phone_sh_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.Supplers.Where(y => y.phone.Contains(txt_phone_sh.Text)).ToList();
		}

		private void txt_phone_sh_Leave(object sender, EventArgs e)
		{
			txt_phone_sh.Clear();
			dataGridView1.DataSource = db.Supplers.ToList();
		}

		private void txt_name_sh_Leave(object sender, EventArgs e)
		{
			txt_name_sh.Clear();
			dataGridView1.DataSource = db.Supplers.ToList();
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

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (txt_phone.Text == string.Empty && txt_name.Text == string.Empty && txt_notes.Text == string.Empty && txt_comp.Text == string.Empty && txt_add.Text == string.Empty && txt_email.Text == string.Empty)
			{
				MessageBox.Show("لا يوجد شئ لتعديله ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
				var result = db.Supplers.SingleOrDefault(x => x.id == index);
				result.Name = txt_name.Text;
				result.phone = txt_phone.Text;
				result.address = txt_add.Text;
				result.Notes = txt_notes.Text;
				if (pictureBox1.ImageLocation != "")
				{
					image_path = pictureBox1.ImageLocation;
					if (Directory.Exists(Environment.CurrentDirectory + "\\images\\Suppler\\"))
					{
						if (File.Exists(Environment.CurrentDirectory + "\\images\\Suppler\\" + result.id + ".jpg"))
						{
							File.Delete(Environment.CurrentDirectory + "\\images\\Suppler\\" + result.id + ".jpg");
							string newimage = Environment.CurrentDirectory + "\\images\\Suppler\\" + result.id + ".jpg";
							File.Copy(image_path, newimage);
							result.Image = newimage;
						}
						else
						{
							string newimage = Environment.CurrentDirectory + "\\images\\Suppler\\" + result.id + ".jpg";
							File.Copy(image_path, newimage);
							result.Image = newimage;
						}
					}
					else
					{
						Directory.CreateDirectory(Environment.CurrentDirectory + "\\images\\Suppler\\");
						string newimage = Environment.CurrentDirectory + "\\images\\Suppler\\" + result.id + ".jpg";
						File.Copy(image_path, newimage);
						result.Image = newimage;
					}

				}
				result.email = txt_email.Text;
				result.company = txt_comp.Text;
				db.SaveChanges();
				dataGridView1.DataSource = db.Supplers.ToList();
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
				var result = db.Supplers.SingleOrDefault(x => x.id == index);
				db.Supplers.Remove(result);
				db.SaveChanges();
				dataGridView1.DataSource = db.Supplers.ToList();
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

		private void NewSupplers_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'supplerDataSet.Supplers' table. You can move, or remove it, as needed.
			this.supplersTableAdapter.Fill(this.supplerDataSet.Supplers);

		}
	}
}
