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
	public partial class update_users : Form
	{

		string image_path;
		SalesEntities db = new SalesEntities();
		public update_users()
		{
			InitializeComponent();
		}
		private void ClearAll()
		{
			txt_user_name.Text = txt_pass.Text = string.Empty;
			pictureBox1.ImageLocation = "";
		}
		private void txt_search_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.Users.Where(y => y.UserName.Contains(txt_search.Text)).ToList();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			var result = db.Users.SingleOrDefault(x => x.id == index);
			txt_user_name.Text = result.UserName;
			txt_pass.Text = result.Password;
			pictureBox1.ImageLocation = result.Image;
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

		private void btn_update_Click(object sender, EventArgs e)
		{
			int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			var result = db.Users.SingleOrDefault(x => x.id == index);
			var con = db.Users.SingleOrDefault(n => n.UserName == txt_user_name.Text);
			if (con != null)
			{

				result.Password = txt_pass.Text;
				result.Image = pictureBox1.ImageLocation;
				db.SaveChanges();
				dataGridView1.DataSource = db.Users.ToList();
			}
			else
			{
				result.UserName = txt_user_name.Text;
				result.Password = txt_pass.Text;
				if (pictureBox1.ImageLocation != "")
				{
					image_path = pictureBox1.ImageLocation;
					if (Directory.Exists(Environment.CurrentDirectory + "\\images\\User\\"))
					{
						if (File.Exists(Environment.CurrentDirectory + "\\images\\User\\" + result.id + ".jpg"))
						{
							File.Delete(Environment.CurrentDirectory + "\\images\\User\\" + result.id + ".jpg");
							string newimage = Environment.CurrentDirectory + "\\images\\User\\" + result.id + ".jpg";
							File.Copy(image_path, newimage);
							result.Image = newimage;
						}
						else
						{
							string newimage = Environment.CurrentDirectory + "\\images\\User\\" + result.id + ".jpg";
							File.Copy(image_path, newimage);
							result.Image = newimage;
						}
					}
					else
					{
						Directory.CreateDirectory(Environment.CurrentDirectory + "\\images\\User\\");
						string newimage = Environment.CurrentDirectory + "\\images\\User\\" + result.id + ".jpg";
						File.Copy(image_path, newimage);
						result.Image = newimage;
					}

				}
				db.SaveChanges();
				dataGridView1.DataSource = db.Users.ToList();

			}
			MessageBox.Show("تم التعديل بنجاح");
			dataGridView1.ClearSelection();
			ClearAll();

		}
		private void btnDel_Click(object sender, EventArgs e)
		{
			var r = MessageBox.Show("هل تريد الحذف", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (r == DialogResult.Yes)
			{
				int index = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
				var result = db.Users.SingleOrDefault(x => x.id == index);
				db.Users.Remove(result);
				db.SaveChanges();
				dataGridView1.DataSource = db.Users.ToList();
				MessageBox.Show("تم الحذف بنجاح");
			}
			dataGridView1.ClearSelection();
			ClearAll();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			User us = new User();
			var temp = db.Users.ToList();
			bool b = false;
			foreach (var item in temp)
			{
				if (item.UserName == txt_user_name.Text && item.Image == pictureBox1.ImageLocation)
				{
					b = true;
				}

			}
			if (b == true)
			{
				MessageBox.Show("هذا المستخدم موجود بالفعل لذلك لن يتم اضافته", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				us.UserName = txt_user_name.Text;
				us.Password = txt_pass.Text;
				if (pictureBox1.ImageLocation != "")
				{
					image_path = pictureBox1.ImageLocation;
					if (Directory.Exists(Environment.CurrentDirectory + "\\images\\User\\"))
					{
						if (File.Exists(Environment.CurrentDirectory + "\\images\\User\\" + us.id + ".jpg"))
						{
							File.Delete(Environment.CurrentDirectory + "\\images\\User\\" + us.id + ".jpg");
							string newimage = Environment.CurrentDirectory + "\\images\\User\\" + us.id + ".jpg";
							File.Copy(image_path, newimage);
							us.Image = newimage;
						}
						else
						{
							string newimage = Environment.CurrentDirectory + "\\images\\User\\" + us.id + ".jpg";
							File.Copy(image_path, newimage);
							us.Image = newimage;
						}
					}
					else
					{
						Directory.CreateDirectory(Environment.CurrentDirectory + "\\images\\User\\");
						string newimage = Environment.CurrentDirectory + "\\images\\User\\" + us.id + ".jpg";
						File.Copy(image_path, newimage);
						us.Image = newimage;
					}

				}
				db.Users.Add(us);
				db.SaveChanges();
				MessageBox.Show("تم الحفظ مرحبا بك");
				dataGridView1.DataSource = db.Users.ToList();
			}

			dataGridView1.ClearSelection();
			ClearAll();
		}

		private void btn_del_picture_Click(object sender, EventArgs e)
		{
			pictureBox1.ImageLocation = "";
		}

		private void update_users_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'userDataSet.Users' table. You can move, or remove it, as needed.
			this.usersTableAdapter.Fill(this.userDataSet.Users);

		}
	}
}













