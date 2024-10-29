namespace RecordShop.UserControllers
{
	partial class Setting
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
			pictureBox2 = new PictureBox();
			label2 = new Label();
			button7 = new Button();
			UserId = new TextBox();
			label1 = new Label();
			label3 = new Label();
			Username = new TextBox();
			label4 = new Label();
			Password = new TextBox();
			HidePassword = new CheckBox();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(247, 115);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(24, 24);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 11;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(277, 115);
			label2.Name = "label2";
			label2.Size = new Size(174, 21);
			label2.TabIndex = 10;
			label2.Text = "User Active Information";
			// 
			// button7
			// 
			button7.Location = new Point(234, 103);
			button7.Name = "button7";
			button7.Size = new Size(980, 285);
			button7.TabIndex = 9;
			button7.UseVisualStyleBackColor = false;
			// 
			// UserId
			// 
			UserId.BackColor = SystemColors.Window;
			UserId.Enabled = false;
			UserId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			UserId.Location = new Point(393, 191);
			UserId.Name = "UserId";
			UserId.ReadOnly = true;
			UserId.Size = new Size(164, 27);
			UserId.TabIndex = 12;
			UserId.TextAlign = HorizontalAlignment.Center;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(393, 168);
			label1.Name = "label1";
			label1.Size = new Size(55, 20);
			label1.TabIndex = 13;
			label1.Text = "User Id";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(393, 231);
			label3.Name = "label3";
			label3.Size = new Size(75, 20);
			label3.TabIndex = 13;
			label3.Text = "Username";
			// 
			// Username
			// 
			Username.BackColor = SystemColors.Window;
			Username.Enabled = false;
			Username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Username.Location = new Point(393, 254);
			Username.Name = "Username";
			Username.ReadOnly = true;
			Username.Size = new Size(360, 27);
			Username.TabIndex = 12;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(393, 294);
			label4.Name = "label4";
			label4.Size = new Size(70, 20);
			label4.TabIndex = 13;
			label4.Text = "Password";
			// 
			// Password
			// 
			Password.BackColor = SystemColors.Window;
			Password.Enabled = false;
			Password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Password.Location = new Point(393, 317);
			Password.Name = "Password";
			Password.ReadOnly = true;
			Password.Size = new Size(225, 27);
			Password.TabIndex = 12;
			Password.UseSystemPasswordChar = true;
			// 
			// HidePassword
			// 
			HidePassword.AutoSize = true;
			HidePassword.Font = new Font("Segoe UI", 11.25F);
			HidePassword.Location = new Point(635, 319);
			HidePassword.Name = "HidePassword";
			HidePassword.Size = new Size(60, 24);
			HidePassword.TabIndex = 14;
			HidePassword.Text = "Hide";
			HidePassword.UseVisualStyleBackColor = true;
			HidePassword.CheckedChanged += HidePassword_CheckedChanged;
			// 
			// Setting
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(HidePassword);
			Controls.Add(Password);
			Controls.Add(label4);
			Controls.Add(Username);
			Controls.Add(label3);
			Controls.Add(UserId);
			Controls.Add(label1);
			Controls.Add(pictureBox2);
			Controls.Add(label2);
			Controls.Add(button7);
			Name = "Setting";
			Size = new Size(1600, 970);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox2;
		private Label label2;
		private Button button7;
		public TextBox UserId;
		private Label label1;
		private Label label3;
		public TextBox Username;
		private Label label4;
		public TextBox Password;
		private CheckBox HidePassword;
	}
}
