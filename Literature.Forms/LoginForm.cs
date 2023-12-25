using System;
using System.Windows.Forms;

namespace Literature.Forms
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			var login = loginInput.Text.Trim();
			var password = PasswordInput.Text.Trim();

			if (login == "admin" && password == "admin")
			{
				this.Hide();

				var mainForm = new MainForm();
				mainForm.ShowDialog();

				this.Show();
			}

			else if (login == "user" && password == "user")
			{
				this.Hide();

				var mainForm = new MainForm();
				GuestForm guestForm = new GuestForm();
				guestForm.ShowDialog();
				this.Show();
			}

			else MessageBox.Show("Invalid user", "Login");
		}
	}
}
