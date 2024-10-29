namespace RecordShop.Views
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			TextUsername = new TextBox();
			label4 = new Label();
			label1 = new Label();
			TextPassword = new TextBox();
			label2 = new Label();
			label3 = new Label();
			pictureBox1 = new PictureBox();
			BtnLogin = new Button();
			UsernameerrorProvider = new ErrorProvider(components);
			PassworderrorProvider = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)UsernameerrorProvider).BeginInit();
			((System.ComponentModel.ISupportInitialize)PassworderrorProvider).BeginInit();
			SuspendLayout();
			// 
			// TextUsername
			// 
			TextUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextUsername.Location = new Point(81, 115);
			TextUsername.Name = "TextUsername";
			TextUsername.PlaceholderText = "Enter Username";
			TextUsername.Size = new Size(264, 27);
			TextUsername.TabIndex = 2;
			TextUsername.TextChanged += TextUsername_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(81, 92);
			label4.Name = "label4";
			label4.Size = new Size(75, 20);
			label4.TabIndex = 3;
			label4.Text = "Username";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(81, 150);
			label1.Name = "label1";
			label1.Size = new Size(70, 20);
			label1.TabIndex = 3;
			label1.Text = "Password";
			// 
			// TextPassword
			// 
			TextPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			TextPassword.Location = new Point(81, 173);
			TextPassword.Name = "TextPassword";
			TextPassword.PlaceholderText = "Enter Password";
			TextPassword.Size = new Size(264, 27);
			TextPassword.TabIndex = 3;
			TextPassword.UseSystemPasswordChar = true;
			TextPassword.TextChanged += TextPassword_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(147, 42);
			label2.Name = "label2";
			label2.Size = new Size(55, 25);
			label2.TabIndex = 43;
			label2.Text = "Shop";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(147, 12);
			label3.Name = "label3";
			label3.Size = new Size(146, 30);
			label3.TabIndex = 42;
			label3.Text = "Vinyl Records";
			// 
			// pictureBox1
			// 
			pictureBox1.ErrorImage = Properties.Resources.icons8_vinyl_record_96;
			pictureBox1.Image = Properties.Resources.icons8_vinyl_record_96;
			pictureBox1.Location = new Point(81, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(60, 60);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 41;
			pictureBox1.TabStop = false;
			// 
			// BtnLogin
			// 
			BtnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnLogin.Image = Properties.Resources.icons8_access_241;
			BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
			BtnLogin.Location = new Point(265, 220);
			BtnLogin.Name = "BtnLogin";
			BtnLogin.Size = new Size(80, 32);
			BtnLogin.TabIndex = 4;
			BtnLogin.Text = "Login";
			BtnLogin.TextAlign = ContentAlignment.MiddleRight;
			BtnLogin.UseVisualStyleBackColor = true;
			BtnLogin.Click += BtnLogin_Click;
			// 
			// UsernameerrorProvider
			// 
			UsernameerrorProvider.ContainerControl = this;
			// 
			// PassworderrorProvider
			// 
			PassworderrorProvider.ContainerControl = this;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			ClientSize = new Size(434, 264);
			Controls.Add(BtnLogin);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(pictureBox1);
			Controls.Add(TextPassword);
			Controls.Add(label1);
			Controls.Add(TextUsername);
			Controls.Add(label4);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)UsernameerrorProvider).EndInit();
			((System.ComponentModel.ISupportInitialize)PassworderrorProvider).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public TextBox TextUsername;
		private Label label4;
		private Label label1;
		public TextBox TextPassword;
		private Label label2;
		private Label label3;
		private PictureBox pictureBox1;
		private ErrorProvider UsernameerrorProvider;
		private ErrorProvider PassworderrorProvider;
		public Button BtnLogin;
	}
}