namespace RecordShop.UserControllers
{
	partial class OrderCard
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
			button8 = new Button();
			pictureBox3 = new PictureBox();
			VinylName = new Label();
			SalePrice = new Label();
			BtnCancel = new Button();
			Quantity = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
			SuspendLayout();
			// 
			// button8
			// 
			button8.Location = new Point(0, 0);
			button8.Name = "button8";
			button8.Size = new Size(328, 60);
			button8.TabIndex = 32;
			button8.UseVisualStyleBackColor = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.icons8_vinyl_record_961;
			pictureBox3.Location = new Point(8, 5);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(50, 50);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 40;
			pictureBox3.TabStop = false;
			// 
			// VinylName
			// 
			VinylName.AutoSize = true;
			VinylName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			VinylName.Location = new Point(66, 3);
			VinylName.Name = "VinylName";
			VinylName.Size = new Size(159, 20);
			VinylName.TabIndex = 41;
			VinylName.Text = "Dark Side of the Moon";
			// 
			// SalePrice
			// 
			SalePrice.AutoSize = true;
			SalePrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SalePrice.Location = new Point(66, 30);
			SalePrice.Name = "SalePrice";
			SalePrice.Size = new Size(52, 20);
			SalePrice.TabIndex = 45;
			SalePrice.Text = "$23.39";
			// 
			// BtnCancel
			// 
			BtnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			BtnCancel.Image = Properties.Resources.icons8_cancel_24;
			BtnCancel.Location = new Point(293, 3);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(32, 32);
			BtnCancel.TabIndex = 46;
			BtnCancel.Text = "-";
			BtnCancel.UseVisualStyleBackColor = true;
			BtnCancel.Click += BtnCancel_Click;
			// 
			// Quantity
			// 
			Quantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Quantity.Location = new Point(128, 27);
			Quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			Quantity.Name = "Quantity";
			Quantity.Size = new Size(90, 27);
			Quantity.TabIndex = 47;
			Quantity.TextAlign = HorizontalAlignment.Center;
			Quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
			Quantity.ValueChanged += Quantity_ValueChanged;
			Quantity.Click += Quantity_Click;
			// 
			// OrderCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(Quantity);
			Controls.Add(BtnCancel);
			Controls.Add(SalePrice);
			Controls.Add(VinylName);
			Controls.Add(pictureBox3);
			Controls.Add(button8);
			Name = "OrderCard";
			Size = new Size(328, 60);
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button8;
		private PictureBox pictureBox3;
		public Label VinylName;
		public Label SalePrice;
		public NumericUpDown Quantity;
		public Button BtnCancel;
	}
}
