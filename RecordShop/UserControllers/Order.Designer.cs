//using static RecordShop.Statics.StaticComponents;
namespace RecordShop.UserControllers
{
	partial class Order
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
			AllVinylRows = new Label();
			SearchField = new TextBox();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			button7 = new Button();
			FlowVinylContainer = new FlowLayoutPanel();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			button1 = new Button();
			FlowBandContainer = new FlowLayoutPanel();
			button8 = new Button();
			label3 = new Label();
			label4 = new Label();
			InvoiceId = new TextBox();
			CbSellerName = new ComboBox();
			CbBuyerName = new ComboBox();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			BtnSubmit = new Button();
			BtnCancel = new Button();
			button2 = new Button();
			FlowOrderContainer = new FlowLayoutPanel();
			Subtotal = new Label();
			DiscountPrice = new Label();
			PayableAmount = new Label();
			label9 = new Label();
			Paid = new NumericUpDown();
			label10 = new Label();
			Remain = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)Paid).BeginInit();
			((System.ComponentModel.ISupportInitialize)Remain).BeginInit();
			SuspendLayout();
			// 
			// AllVinylRows
			// 
			AllVinylRows.AutoSize = true;
			AllVinylRows.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			AllVinylRows.Location = new Point(27, 923);
			AllVinylRows.Name = "AllVinylRows";
			AllVinylRows.Size = new Size(70, 20);
			AllVinylRows.TabIndex = 19;
			AllVinylRows.Text = "Rows: 0.0";
			// 
			// SearchField
			// 
			SearchField.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SearchField.Location = new Point(36, 154);
			SearchField.Multiline = true;
			SearchField.Name = "SearchField";
			SearchField.PlaceholderText = "Search By Name";
			SearchField.Size = new Size(476, 28);
			SearchField.TabIndex = 24;
			SearchField.TextChanged += SearchField_TextChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.icons8_shop_24;
			pictureBox2.Location = new Point(27, 27);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(24, 24);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 22;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(57, 27);
			label2.Name = "label2";
			label2.Size = new Size(130, 21);
			label2.TabIndex = 21;
			label2.Text = "Vinyl Shop Order";
			// 
			// button7
			// 
			button7.Location = new Point(14, 15);
			button7.Name = "button7";
			button7.Size = new Size(1157, 942);
			button7.TabIndex = 20;
			button7.UseVisualStyleBackColor = false;
			// 
			// FlowVinylContainer
			// 
			FlowVinylContainer.AutoScroll = true;
			FlowVinylContainer.Location = new Point(27, 194);
			FlowVinylContainer.Name = "FlowVinylContainer";
			FlowVinylContainer.Size = new Size(1129, 710);
			FlowVinylContainer.TabIndex = 26;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_mobile_order_26;
			pictureBox1.Location = new Point(1205, 30);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(26, 26);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 29;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(1235, 30);
			label1.Name = "label1";
			label1.Size = new Size(150, 21);
			label1.TabIndex = 28;
			label1.Text = "Order Vinyl Records";
			// 
			// button1
			// 
			button1.Location = new Point(1191, 15);
			button1.Name = "button1";
			button1.Size = new Size(395, 942);
			button1.TabIndex = 27;
			button1.UseVisualStyleBackColor = false;
			// 
			// FlowBandContainer
			// 
			FlowBandContainer.AutoScroll = true;
			FlowBandContainer.Location = new Point(36, 73);
			FlowBandContainer.Name = "FlowBandContainer";
			FlowBandContainer.Size = new Size(1108, 61);
			FlowBandContainer.TabIndex = 30;
			FlowBandContainer.WrapContents = false;
			// 
			// button8
			// 
			button8.Location = new Point(25, 64);
			button8.Name = "button8";
			button8.Size = new Size(1131, 78);
			button8.TabIndex = 31;
			button8.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(1205, 79);
			label3.Name = "label3";
			label3.Size = new Size(83, 20);
			label3.TabIndex = 33;
			label3.Text = "Invoice No.";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(1205, 117);
			label4.Name = "label4";
			label4.Size = new Size(90, 20);
			label4.TabIndex = 33;
			label4.Text = "Seller Name";
			// 
			// InvoiceId
			// 
			InvoiceId.BackColor = SystemColors.Window;
			InvoiceId.Enabled = false;
			InvoiceId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			InvoiceId.Location = new Point(1311, 76);
			InvoiceId.Name = "InvoiceId";
			InvoiceId.ReadOnly = true;
			InvoiceId.Size = new Size(177, 27);
			InvoiceId.TabIndex = 34;
			InvoiceId.Text = "0001";
			InvoiceId.TextAlign = HorizontalAlignment.Center;
			// 
			// CbSellerName
			// 
			CbSellerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			CbSellerName.FormattingEnabled = true;
			CbSellerName.Location = new Point(1311, 114);
			CbSellerName.Name = "CbSellerName";
			CbSellerName.Size = new Size(261, 28);
			CbSellerName.TabIndex = 35;
			// 
			// CbBuyerName
			// 
			CbBuyerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			CbBuyerName.FormattingEnabled = true;
			CbBuyerName.Location = new Point(1311, 154);
			CbBuyerName.Name = "CbBuyerName";
			CbBuyerName.Size = new Size(261, 28);
			CbBuyerName.TabIndex = 37;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(1205, 157);
			label5.Name = "label5";
			label5.Size = new Size(90, 20);
			label5.TabIndex = 36;
			label5.Text = "Buyer Name";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(1205, 796);
			label6.Name = "label6";
			label6.Size = new Size(72, 20);
			label6.TabIndex = 36;
			label6.Text = "Subtotal: ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.Location = new Point(1205, 825);
			label7.Name = "label7";
			label7.Size = new Size(74, 20);
			label7.TabIndex = 36;
			label7.Text = "Discount: ";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.Location = new Point(1205, 863);
			label8.Name = "label8";
			label8.Size = new Size(130, 21);
			label8.TabIndex = 36;
			label8.Text = "Payable Amount: ";
			// 
			// BtnSubmit
			// 
			BtnSubmit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnSubmit.Image = (Image)resources.GetObject("BtnSubmit.Image");
			BtnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
			BtnSubmit.Location = new Point(1478, 911);
			BtnSubmit.Name = "BtnSubmit";
			BtnSubmit.Size = new Size(94, 32);
			BtnSubmit.TabIndex = 38;
			BtnSubmit.Text = "Submit";
			BtnSubmit.TextAlign = ContentAlignment.MiddleRight;
			BtnSubmit.UseVisualStyleBackColor = true;
			BtnSubmit.Click += BtnSubmit_Click;
			// 
			// BtnCancel
			// 
			BtnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
			BtnCancel.ImageAlign = ContentAlignment.MiddleLeft;
			BtnCancel.Location = new Point(1368, 911);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(94, 32);
			BtnCancel.TabIndex = 38;
			BtnCancel.Text = "Cancel";
			BtnCancel.TextAlign = ContentAlignment.MiddleRight;
			BtnCancel.UseVisualStyleBackColor = true;
			BtnCancel.Click += BtnCancel_Click;
			// 
			// button2
			// 
			button2.Location = new Point(1202, 194);
			button2.Name = "button2";
			button2.Size = new Size(373, 588);
			button2.TabIndex = 39;
			button2.UseVisualStyleBackColor = false;
			// 
			// FlowOrderContainer
			// 
			FlowOrderContainer.AutoScroll = true;
			FlowOrderContainer.Location = new Point(1210, 208);
			FlowOrderContainer.Name = "FlowOrderContainer";
			FlowOrderContainer.Padding = new Padding(3, 0, 0, 0);
			FlowOrderContainer.Size = new Size(357, 559);
			FlowOrderContainer.TabIndex = 33;
			// 
			// Subtotal
			// 
			Subtotal.AutoSize = true;
			Subtotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Subtotal.Location = new Point(1283, 796);
			Subtotal.Name = "Subtotal";
			Subtotal.Size = new Size(29, 20);
			Subtotal.TabIndex = 36;
			Subtotal.Text = "0.0";
			// 
			// DiscountPrice
			// 
			DiscountPrice.AutoSize = true;
			DiscountPrice.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			DiscountPrice.Location = new Point(1285, 825);
			DiscountPrice.Name = "DiscountPrice";
			DiscountPrice.Size = new Size(37, 20);
			DiscountPrice.TabIndex = 36;
			DiscountPrice.Text = "$0.0";
			// 
			// PayableAmount
			// 
			PayableAmount.AutoSize = true;
			PayableAmount.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			PayableAmount.Location = new Point(1341, 864);
			PayableAmount.Name = "PayableAmount";
			PayableAmount.Size = new Size(37, 20);
			PayableAmount.TabIndex = 36;
			PayableAmount.Text = "$0.0";
			PayableAmount.TextChanged += PayableAmount_TextChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label9.Location = new Point(1404, 796);
			label9.Name = "label9";
			label9.Size = new Size(52, 20);
			label9.TabIndex = 36;
			label9.Text = "Paid: $";
			// 
			// Paid
			// 
			Paid.DecimalPlaces = 2;
			Paid.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Paid.Location = new Point(1462, 793);
			Paid.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			Paid.Name = "Paid";
			Paid.Size = new Size(110, 27);
			Paid.TabIndex = 48;
			Paid.TextAlign = HorizontalAlignment.Center;
			Paid.ThousandsSeparator = true;
			Paid.ValueChanged += Paid_ValueChanged;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label10.Location = new Point(1382, 824);
			label10.Name = "label10";
			label10.Size = new Size(74, 20);
			label10.TabIndex = 36;
			label10.Text = "Remain: $";
			// 
			// Remain
			// 
			Remain.DecimalPlaces = 2;
			Remain.Enabled = false;
			Remain.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Remain.Location = new Point(1462, 822);
			Remain.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			Remain.Name = "Remain";
			Remain.ReadOnly = true;
			Remain.Size = new Size(110, 27);
			Remain.TabIndex = 48;
			Remain.TextAlign = HorizontalAlignment.Center;
			Remain.ThousandsSeparator = true;
			Remain.ValueChanged += Remain_ValueChanged;
			// 
			// Order
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(Remain);
			Controls.Add(Paid);
			Controls.Add(FlowOrderContainer);
			Controls.Add(button2);
			Controls.Add(BtnCancel);
			Controls.Add(BtnSubmit);
			Controls.Add(CbBuyerName);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(PayableAmount);
			Controls.Add(DiscountPrice);
			Controls.Add(Subtotal);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(CbSellerName);
			Controls.Add(InvoiceId);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(FlowBandContainer);
			Controls.Add(button8);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(FlowVinylContainer);
			Controls.Add(AllVinylRows);
			Controls.Add(SearchField);
			Controls.Add(pictureBox2);
			Controls.Add(label2);
			Controls.Add(button7);
			Name = "Order";
			Size = new Size(1600, 970);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)Paid).EndInit();
			((System.ComponentModel.ISupportInitialize)Remain).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label AllVinylRows;
		private TextBox SearchField;
		private PictureBox pictureBox2;
		private Label label2;
		private Button button7;
		private FlowLayoutPanel FlowVinylContainer;
		private PictureBox pictureBox1;
		private Label label1;
		private Button button1;
		private FlowLayoutPanel FlowBandContainer;
		private Button button8;
		private Label label3;
		private Label label4;
		private TextBox InvoiceId;
		private ComboBox CbSellerName;
		private ComboBox CbBuyerName;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Button BtnSubmit;
		private Button BtnCancel;
		private Button button2;
		private Label Subtotal;
		private Label DiscountPrice;
		private Label PayableAmount;
		public FlowLayoutPanel FlowOrderContainer;
		private Label label9;
		public NumericUpDown Paid;
		private Label label10;
		public NumericUpDown Remain;
	}
}
