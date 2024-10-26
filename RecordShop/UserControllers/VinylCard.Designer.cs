namespace RecordShop.UserControllers
{
	partial class VinylCard
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
			SalePrice = new Label();
			Publisher = new Label();
			GenreName = new Label();
			BandName = new Label();
			VinylName = new Label();
			pictureBox3 = new PictureBox();
			BtnVinylCard = new Button();
			OldPrice = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// SalePrice
			// 
			SalePrice.AutoSize = true;
			SalePrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SalePrice.Location = new Point(201, 97);
			SalePrice.Name = "SalePrice";
			SalePrice.Size = new Size(52, 20);
			SalePrice.TabIndex = 44;
			SalePrice.Text = "$23.39";
			// 
			// Publisher
			// 
			Publisher.AutoSize = true;
			Publisher.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Publisher.Location = new Point(67, 49);
			Publisher.Name = "Publisher";
			Publisher.Size = new Size(191, 15);
			Publisher.TabIndex = 42;
			Publisher.Text = "Publisher: Penguin Random House";
			// 
			// GenreName
			// 
			GenreName.AutoSize = true;
			GenreName.Font = new Font("Segoe UI", 9.75F);
			GenreName.Location = new Point(67, 31);
			GenreName.Name = "GenreName";
			GenreName.Size = new Size(78, 17);
			GenreName.TabIndex = 43;
			GenreName.Text = "Genre: Rock";
			// 
			// BandName
			// 
			BandName.AutoSize = true;
			BandName.Font = new Font("Segoe UI", 9.75F);
			BandName.Location = new Point(67, 14);
			BandName.Name = "BandName";
			BandName.Size = new Size(102, 17);
			BandName.TabIndex = 41;
			BandName.Text = "Band: Pink Floyd";
			// 
			// VinylName
			// 
			VinylName.AutoSize = true;
			VinylName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			VinylName.Location = new Point(11, 70);
			VinylName.Name = "VinylName";
			VinylName.Size = new Size(159, 20);
			VinylName.TabIndex = 40;
			VinylName.Text = "Dark Side of the Moon";
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.icons8_vinyl_record_961;
			pictureBox3.Location = new Point(11, 14);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(50, 50);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 39;
			pictureBox3.TabStop = false;
			// 
			// BtnVinylCard
			// 
			BtnVinylCard.Location = new Point(0, 0);
			BtnVinylCard.Name = "BtnVinylCard";
			BtnVinylCard.Size = new Size(272, 135);
			BtnVinylCard.TabIndex = 38;
			BtnVinylCard.UseVisualStyleBackColor = false;
			BtnVinylCard.Click += BtnVinylCard_Click;
			// 
			// OldPrice
			// 
			OldPrice.AutoSize = true;
			OldPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
			OldPrice.ForeColor = SystemColors.ButtonShadow;
			OldPrice.Location = new Point(143, 97);
			OldPrice.Name = "OldPrice";
			OldPrice.Size = new Size(0, 20);
			OldPrice.TabIndex = 44;
			// 
			// VinylCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(OldPrice);
			Controls.Add(SalePrice);
			Controls.Add(Publisher);
			Controls.Add(GenreName);
			Controls.Add(BandName);
			Controls.Add(VinylName);
			Controls.Add(pictureBox3);
			Controls.Add(BtnVinylCard);
			Name = "VinylCard";
			Size = new Size(272, 135);
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pictureBox3;
		private Button BtnVinylCard;
		public Label OldPrice;
		public Label BandName;
		public Label SalePrice;
		public Label Publisher;
		public Label GenreName;
		public Label VinylName;
	}
}
