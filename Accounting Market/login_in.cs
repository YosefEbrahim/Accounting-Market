using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.db;

namespace WindowsFormsApplication5
{
	public partial class user : Form
	{
		SalesEntities db = new SalesEntities();

		public user()
		{
			InitializeComponent();
		}

		public void button1_Click(object sender, EventArgs e)
		{
			var result = db.Users.Where(y => y.UserName == txtuser_name.Text && y.Password == txt_password.Text).ToList();
			if (result == null)
			{
				if (txtuser_name.Text == "admin" && txt_password.Text == "admin")
				{
					this.Close();
					Thread th = new Thread(open_form);
					th.SetApartmentState(ApartmentState.STA);
					th.Start();
				}
				else
				{
					txtuser_name.Clear();
					txt_password.Clear();
					MessageBox.Show("الرجاء استخدام \n admin فى اسم المستخدم و كلمة المرور");
				}
			}
			else
			{
				if (result.Count() > 0)
				{
					this.Close();
					Thread th = new Thread(open_form);
					th.SetApartmentState(ApartmentState.STA);
					th.Start();
				}
				else
				{
					txtuser_name.Clear();
					txt_password.Clear();
					MessageBox.Show("اسم المستخدم او كلمه المرور غير صحيحه");
				}
			}
		}
		void open_form()
		{
			Application.Run(new main_Form());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (txt_password.PasswordChar == '*')
				txt_password.PasswordChar = '\0';
			else
				txt_password.PasswordChar = '*';
		}
	}
}
