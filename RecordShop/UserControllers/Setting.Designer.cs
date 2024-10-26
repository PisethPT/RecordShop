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
			VinylId = new TextBox();
			label1 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			label4 = new Label();
			textBox2 = new TextBox();
			checkBox1 = new CheckBox();
			SearchType = new ComboBox();
			label5 = new Label();
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
			// VinylId
			// 
			VinylId.BackColor = SystemColors.Window;
			VinylId.Enabled = false;
			VinylId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			VinylId.Location = new Point(393, 191);
			VinylId.Name = "VinylId";
			VinylId.ReadOnly = true;
			VinylId.Size = new Size(164, 27);
			VinylId.TabIndex = 12;
			VinylId.TextAlign = HorizontalAlignment.Center;
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
			// textBox1
			// 
			textBox1.BackColor = SystemColors.Window;
			textBox1.Enabled = false;
			textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox1.Location = new Point(393, 254);
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new Size(360, 27);
			textBox1.TabIndex = 12;
			textBox1.TextAlign = HorizontalAlignment.Center;
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
			// textBox2
			// 
			textBox2.BackColor = SystemColors.Window;
			textBox2.Enabled = false;
			textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox2.Location = new Point(393, 317);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(225, 27);
			textBox2.TabIndex = 12;
			textBox2.TextAlign = HorizontalAlignment.Center;
			textBox2.UseSystemPasswordChar = true;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Segoe UI", 11.25F);
			checkBox1.Location = new Point(635, 319);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(60, 24);
			checkBox1.TabIndex = 14;
			checkBox1.Text = "Hide";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// SearchType
			// 
			SearchType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SearchType.FormattingEnabled = true;
			SearchType.Items.AddRange(new object[] { "Name", "Band", "Genre" });
			SearchType.Location = new Point(978, 253);
			SearchType.Name = "SearchType";
			SearchType.Size = new Size(160, 28);
			SearchType.TabIndex = 15;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(897, 257);
			label5.Name = "label5";
			label5.Size = new Size(73, 20);
			label5.TabIndex = 13;
			label5.Text = "User Type";
			// 
			// Setting
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(SearchType);
			Controls.Add(checkBox1);
			Controls.Add(textBox2);
			Controls.Add(label4);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(VinylId);
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
		public TextBox VinylId;
		private Label label1;
		private Label label3;
		public TextBox textBox1;
		private Label label4;
		public TextBox textBox2;
		private CheckBox checkBox1;
		private ComboBox SearchType;
		private Label label5;
	}
}
