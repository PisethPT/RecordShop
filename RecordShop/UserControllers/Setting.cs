using RecordShop.Data;

namespace RecordShop.UserControllers
{
	public partial class Setting : UserControl
	{
		private readonly VinylRecordsContext context;
		public Setting()
		{
			InitializeComponent();
			context = new VinylRecordsContext();
			var userId = context.Users.FirstOrDefault(u => u.Username == RecordShop.Views.Login.Username)!.UserId;
			this.UserId.Text = userId.ToString();
			this.Username.Text = RecordShop.Views.Login.Username;
			this.Password.Text = RecordShop.Views.Login.Password;
		}

		private void HidePassword_CheckedChanged(object sender, EventArgs e)
		{
			if (this.HidePassword.Checked)
				this.Password.UseSystemPasswordChar = false;
			else
				this.Password.UseSystemPasswordChar = true;
		}
	}
}
