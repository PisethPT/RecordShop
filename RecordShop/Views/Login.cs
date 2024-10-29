using RecordShop.Data;
using static RecordShop.Views.Shop;

namespace RecordShop.Views
{
	public partial class Login : Form
	{
		private readonly VinylRecordsContext context;
		public static string Username { get; set; } = string.Empty;
		public static string Password { get; set; } = string.Empty;
		public Login()
		{
			InitializeComponent();
			context = new VinylRecordsContext();
			this.TextUsername.Select();
			this.TextPassword.KeyPress += TextPassword_KeyPress;
		}

		private void TextPassword_KeyPress(object? sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.GetHashCode().Equals(851981)) // Keys.Enter
			{
				BtnLogin_Click(sender!, e);
			}
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(this.TextUsername.Text) || string.IsNullOrWhiteSpace(this.TextUsername.Text))
			{
				this.UsernameerrorProvider.SetError(this.TextUsername, "Username require.");
				return;
			}
			else
				Username = this.TextUsername.Text;


			if (string.IsNullOrEmpty(this.TextPassword.Text) || string.IsNullOrWhiteSpace(this.TextPassword.Text))
			{
				this.PassworderrorProvider.SetError(this.TextPassword, "Password require.");
				return;
			}
			else
				Password = this.TextPassword.Text;

			var user = context.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);
			if (user != null)
			{
				this.BtnLogin.Enabled = false;
				this.Hide();
				ShopInstant = new Shop();
				ShopInstant.Show();
			}
			else
			{
				MessageBox.Show("Your Username or Password not valid.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			
		}

		private void TextUsername_TextChanged(object sender, EventArgs e) => this.UsernameerrorProvider.SetError(this.TextUsername, string.Empty);

		private void TextPassword_TextChanged(object sender, EventArgs e) => this.PassworderrorProvider.SetError(this.TextPassword, string.Empty);

		
	}
}
