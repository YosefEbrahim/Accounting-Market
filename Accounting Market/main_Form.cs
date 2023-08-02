using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.screens;

namespace WindowsFormsApplication5
{
	public partial class main_Form : Form
	{
		public main_Form()
		{

			InitializeComponent();
			timer1.Start();


		}
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			update_product fm = new update_product();
			fm.Show();
		}
		private void عرضالمستحدمينToolStripMenuItem_Click(object sender, EventArgs e)
		{
			update_users newUs = new update_users();
			newUs.Show();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("T");
			lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
		}

		private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewCustomer cs = new NewCustomer();
			cs.Show();
		}

		private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewSupplers sp = new NewSupplers();
			sp.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			BillForm bill = new BillForm();
			bill.Show();
		}
	}
}
