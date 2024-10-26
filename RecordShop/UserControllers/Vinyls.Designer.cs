using System.Windows.Forms;

namespace RecordShop.UserControllers
{
	partial class Vinyls
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vinyls));
			pictureBox2 = new PictureBox();
			label2 = new Label();
			button7 = new Button();
			button1 = new Button();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			BtnNewVinyl = new Button();
			SearchType = new ComboBox();
			SearchField = new TextBox();
			pictureBox3 = new PictureBox();
			label3 = new Label();
			button3 = new Button();
			AllVinylRecordsTable = new DataGridView();
			panel2 = new Panel();
			VinylName = new TextBox();
			label4 = new Label();
			BtnSubmit = new Button();
			panel5 = new Panel();
			SellingPrice = new NumericUpDown();
			label5 = new Label();
			panel7 = new Panel();
			DiscountDate = new DateTimePicker();
			label7 = new Label();
			BtnCancel = new Button();
			VinylDiscountTable = new DataGridView();
			AllVinylRows = new Label();
			DiscountVinylRows = new Label();
			BtnDelete = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)AllVinylRecordsTable).BeginInit();
			panel2.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SellingPrice).BeginInit();
			panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)VinylDiscountTable).BeginInit();
			SuspendLayout();
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.icons8_music_library_24;
			pictureBox2.Location = new Point(27, 24);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(24, 24);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 8;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(57, 24);
			label2.Name = "label2";
			label2.Size = new Size(127, 21);
			label2.TabIndex = 7;
			label2.Text = "All Vinyl Records";
			// 
			// button7
			// 
			button7.Location = new Point(14, 12);
			button7.Name = "button7";
			button7.Size = new Size(1131, 942);
			button7.TabIndex = 6;
			button7.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.Location = new Point(1167, 13);
			button1.Name = "button1";
			button1.Size = new Size(418, 295);
			button1.TabIndex = 9;
			button1.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_sale_24;
			pictureBox1.Location = new Point(1184, 27);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(24, 24);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 11;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(1214, 27);
			label1.Name = "label1";
			label1.Size = new Size(144, 21);
			label1.TabIndex = 10;
			label1.Text = "Add-Vinyl Discount";
			// 
			// BtnNewVinyl
			// 
			BtnNewVinyl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnNewVinyl.Image = Properties.Resources.icons8_doctors_folder_24;
			BtnNewVinyl.ImageAlign = ContentAlignment.MiddleLeft;
			BtnNewVinyl.Location = new Point(1016, 72);
			BtnNewVinyl.Name = "BtnNewVinyl";
			BtnNewVinyl.Size = new Size(108, 32);
			BtnNewVinyl.TabIndex = 12;
			BtnNewVinyl.Text = "New Vinyl";
			BtnNewVinyl.TextAlign = ContentAlignment.MiddleRight;
			BtnNewVinyl.UseVisualStyleBackColor = true;
			BtnNewVinyl.Click += BtnNewVinyl_Click;
			// 
			// SearchType
			// 
			SearchType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SearchType.FormattingEnabled = true;
			SearchType.Items.AddRange(new object[] { "Name", "Band", "Genre" });
			SearchType.Location = new Point(212, 72);
			SearchType.Name = "SearchType";
			SearchType.Size = new Size(160, 28);
			SearchType.TabIndex = 13;
			SearchType.SelectedIndexChanged += SearchType_SelectedIndexChanged;
			// 
			// SearchField
			// 
			SearchField.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SearchField.Location = new Point(378, 72);
			SearchField.Multiline = true;
			SearchField.Name = "SearchField";
			SearchField.PlaceholderText = "Search By Name";
			SearchField.Size = new Size(476, 28);
			SearchField.TabIndex = 14;
			SearchField.TextChanged += SearchField_TextChanged;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.icons8_compact_24;
			pictureBox3.Location = new Point(1184, 347);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(24, 24);
			pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox3.TabIndex = 17;
			pictureBox3.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(1214, 347);
			label3.Name = "label3";
			label3.Size = new Size(139, 21);
			label3.TabIndex = 16;
			label3.Text = "All Vinyls Discount";
			// 
			// button3
			// 
			button3.Location = new Point(1167, 333);
			button3.Name = "button3";
			button3.Size = new Size(418, 621);
			button3.TabIndex = 15;
			button3.UseVisualStyleBackColor = false;
			// 
			// AllVinylRecordsTable
			// 
			AllVinylRecordsTable.AllowUserToAddRows = false;
			AllVinylRecordsTable.AllowUserToDeleteRows = false;
			AllVinylRecordsTable.AllowUserToResizeRows = false;
			AllVinylRecordsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			AllVinylRecordsTable.BackgroundColor = SystemColors.Window;
			AllVinylRecordsTable.BorderStyle = BorderStyle.None;
			AllVinylRecordsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Window;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
			AllVinylRecordsTable.DefaultCellStyle = dataGridViewCellStyle1;
			AllVinylRecordsTable.GridColor = SystemColors.Window;
			AllVinylRecordsTable.Location = new Point(25, 122);
			AllVinylRecordsTable.MultiSelect = false;
			AllVinylRecordsTable.Name = "AllVinylRecordsTable";
			AllVinylRecordsTable.ReadOnly = true;
			AllVinylRecordsTable.RowHeadersVisible = false;
			AllVinylRecordsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			AllVinylRecordsTable.Size = new Size(1108, 795);
			AllVinylRecordsTable.TabIndex = 18;
			// 
			// panel2
			// 
			panel2.Controls.Add(VinylName);
			panel2.Controls.Add(label4);
			panel2.Location = new Point(1183, 72);
			panel2.Name = "panel2";
			panel2.Size = new Size(387, 54);
			panel2.TabIndex = 19;
			// 
			// VinylName
			// 
			VinylName.BackColor = SystemColors.Window;
			VinylName.Enabled = false;
			VinylName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			VinylName.Location = new Point(3, 23);
			VinylName.Name = "VinylName";
			VinylName.ReadOnly = true;
			VinylName.Size = new Size(381, 27);
			VinylName.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(3, 0);
			label4.Name = "label4";
			label4.Size = new Size(94, 20);
			label4.TabIndex = 1;
			label4.Text = "Vinyl's Name";
			// 
			// BtnSubmit
			// 
			BtnSubmit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnSubmit.Image = Properties.Resources.icons8_doctors_folder_24;
			BtnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
			BtnSubmit.Location = new Point(1480, 262);
			BtnSubmit.Name = "BtnSubmit";
			BtnSubmit.Size = new Size(91, 32);
			BtnSubmit.TabIndex = 20;
			BtnSubmit.Text = "Submit";
			BtnSubmit.TextAlign = ContentAlignment.MiddleRight;
			BtnSubmit.UseVisualStyleBackColor = true;
			BtnSubmit.Click += BtnSubmit_Click;
			// 
			// panel5
			// 
			panel5.Controls.Add(SellingPrice);
			panel5.Controls.Add(label5);
			panel5.Location = new Point(1184, 132);
			panel5.Name = "panel5";
			panel5.Size = new Size(387, 54);
			panel5.TabIndex = 21;
			// 
			// SellingPrice
			// 
			SellingPrice.BorderStyle = BorderStyle.FixedSingle;
			SellingPrice.DecimalPlaces = 2;
			SellingPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SellingPrice.Location = new Point(3, 23);
			SellingPrice.Name = "SellingPrice";
			SellingPrice.Size = new Size(209, 27);
			SellingPrice.TabIndex = 3;
			SellingPrice.TextAlign = HorizontalAlignment.Center;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(3, 0);
			label5.Name = "label5";
			label5.Size = new Size(132, 20);
			label5.TabIndex = 1;
			label5.Text = "Selling Price (10%)";
			// 
			// panel7
			// 
			panel7.Controls.Add(DiscountDate);
			panel7.Controls.Add(label7);
			panel7.Location = new Point(1184, 192);
			panel7.Name = "panel7";
			panel7.Size = new Size(387, 54);
			panel7.TabIndex = 22;
			// 
			// DiscountDate
			// 
			DiscountDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			DiscountDate.Location = new Point(3, 23);
			DiscountDate.Name = "DiscountDate";
			DiscountDate.Size = new Size(262, 27);
			DiscountDate.TabIndex = 7;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.Location = new Point(3, 0);
			label7.Name = "label7";
			label7.Size = new Size(103, 20);
			label7.TabIndex = 1;
			label7.Text = "Discount Date";
			// 
			// BtnCancel
			// 
			BtnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnCancel.Image = Properties.Resources.icons8_remove_24;
			BtnCancel.ImageAlign = ContentAlignment.MiddleLeft;
			BtnCancel.Location = new Point(1383, 262);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(91, 32);
			BtnCancel.TabIndex = 20;
			BtnCancel.Text = "Cancel";
			BtnCancel.TextAlign = ContentAlignment.MiddleRight;
			BtnCancel.UseVisualStyleBackColor = true;
			BtnCancel.Click += BtnCancel_Click;
			// 
			// VinylDiscountTable
			// 
			VinylDiscountTable.AllowUserToAddRows = false;
			VinylDiscountTable.AllowUserToDeleteRows = false;
			VinylDiscountTable.AllowUserToResizeRows = false;
			VinylDiscountTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			VinylDiscountTable.BackgroundColor = SystemColors.Window;
			VinylDiscountTable.BorderStyle = BorderStyle.None;
			VinylDiscountTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			VinylDiscountTable.DefaultCellStyle = dataGridViewCellStyle2;
			VinylDiscountTable.GridColor = SystemColors.Window;
			VinylDiscountTable.Location = new Point(1176, 388);
			VinylDiscountTable.MultiSelect = false;
			VinylDiscountTable.Name = "VinylDiscountTable";
			VinylDiscountTable.ReadOnly = true;
			VinylDiscountTable.RowHeadersVisible = false;
			VinylDiscountTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			VinylDiscountTable.Size = new Size(400, 529);
			VinylDiscountTable.TabIndex = 23;
			// 
			// AllVinylRows
			// 
			AllVinylRows.AutoSize = true;
			AllVinylRows.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			AllVinylRows.Location = new Point(27, 920);
			AllVinylRows.Name = "AllVinylRows";
			AllVinylRows.Size = new Size(70, 20);
			AllVinylRows.TabIndex = 2;
			AllVinylRows.Text = "Rows: 0.0";
			// 
			// DiscountVinylRows
			// 
			DiscountVinylRows.AutoSize = true;
			DiscountVinylRows.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			DiscountVinylRows.Location = new Point(1183, 920);
			DiscountVinylRows.Name = "DiscountVinylRows";
			DiscountVinylRows.Size = new Size(70, 20);
			DiscountVinylRows.TabIndex = 2;
			DiscountVinylRows.Text = "Rows: 0.0";
			// 
			// BtnDelete
			// 
			BtnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
			BtnDelete.ImageAlign = ContentAlignment.MiddleLeft;
			BtnDelete.Location = new Point(1286, 262);
			BtnDelete.Name = "BtnDelete";
			BtnDelete.Size = new Size(91, 32);
			BtnDelete.TabIndex = 24;
			BtnDelete.Text = "Remove";
			BtnDelete.TextAlign = ContentAlignment.MiddleRight;
			BtnDelete.UseVisualStyleBackColor = true;
			BtnDelete.Visible = false;
			// 
			// Vinyls
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(BtnDelete);
			Controls.Add(DiscountVinylRows);
			Controls.Add(AllVinylRows);
			Controls.Add(VinylDiscountTable);
			Controls.Add(panel7);
			Controls.Add(panel5);
			Controls.Add(BtnCancel);
			Controls.Add(BtnSubmit);
			Controls.Add(panel2);
			Controls.Add(AllVinylRecordsTable);
			Controls.Add(pictureBox3);
			Controls.Add(label3);
			Controls.Add(button3);
			Controls.Add(SearchField);
			Controls.Add(SearchType);
			Controls.Add(BtnNewVinyl);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(pictureBox2);
			Controls.Add(label2);
			Controls.Add(button7);
			Name = "Vinyls";
			Size = new Size(1600, 970);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)AllVinylRecordsTable).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)SellingPrice).EndInit();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)VinylDiscountTable).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox2;
		private Label label2;
		private Button button7;
		private Button button1;
		private PictureBox pictureBox1;
		private Label label1;
		private Button BtnNewVinyl;
		private ComboBox SearchType;
		private TextBox SearchField;
		private PictureBox pictureBox3;
		private Label label3;
		private Button button3;
		private DataGridView AllVinylRecordsTable;
		private Panel panel2;
		public TextBox VinylName;
		private Label label4;
		private Button BtnSubmit;
		private Panel panel5;
		public NumericUpDown SellingPrice;
		private Label label5;
		private Panel panel7;
		public DateTimePicker DiscountDate;
		private Label label7;
		private Button BtnCancel;
		private DataGridView VinylDiscountTable;
		private Label AllVinylRows;
		private Label DiscountVinylRows;
		private Button BtnDelete;
	}
}
