namespace RecordShop.UserControllers
{
	partial class Buyer
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
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			BuyersRows = new Label();
			SearchField = new TextBox();
			BuyersListTable = new DataGridView();
			BtnCancel = new Button();
			BtnDelete = new Button();
			BtnModify = new Button();
			panel4 = new Panel();
			RichAddress = new RichTextBox();
			label6 = new Label();
			panel3 = new Panel();
			Phone = new TextBox();
			label5 = new Label();
			panel2 = new Panel();
			BuyerName = new TextBox();
			label4 = new Label();
			panel1 = new Panel();
			BuyerId = new TextBox();
			label3 = new Label();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			button1 = new Button();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			button7 = new Button();
			BuyerNameRequire = new ErrorProvider(components);
			PhoneRequire = new ErrorProvider(components);
			AddressRequire = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)BuyersListTable).BeginInit();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)BuyerNameRequire).BeginInit();
			((System.ComponentModel.ISupportInitialize)PhoneRequire).BeginInit();
			((System.ComponentModel.ISupportInitialize)AddressRequire).BeginInit();
			SuspendLayout();
			// 
			// BuyersRows
			// 
			BuyersRows.AutoSize = true;
			BuyersRows.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BuyersRows.Location = new Point(28, 920);
			BuyersRows.Name = "BuyersRows";
			BuyersRows.Size = new Size(70, 20);
			BuyersRows.TabIndex = 58;
			BuyersRows.Text = "Rows: 0.0";
			// 
			// SearchField
			// 
			SearchField.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SearchField.Location = new Point(336, 60);
			SearchField.Multiline = true;
			SearchField.Name = "SearchField";
			SearchField.PlaceholderText = "Search By Name";
			SearchField.Size = new Size(476, 28);
			SearchField.TabIndex = 57;
			SearchField.TextChanged += SearchField_TextChanged;
			// 
			// BuyersListTable
			// 
			BuyersListTable.AllowUserToAddRows = false;
			BuyersListTable.AllowUserToDeleteRows = false;
			BuyersListTable.AllowUserToResizeRows = false;
			BuyersListTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			BuyersListTable.BackgroundColor = SystemColors.Window;
			BuyersListTable.BorderStyle = BorderStyle.None;
			BuyersListTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLight;
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			BuyersListTable.DefaultCellStyle = dataGridViewCellStyle3;
			BuyersListTable.GridColor = SystemColors.Window;
			BuyersListTable.Location = new Point(28, 106);
			BuyersListTable.MultiSelect = false;
			BuyersListTable.Name = "BuyersListTable";
			BuyersListTable.ReadOnly = true;
			BuyersListTable.RowHeadersVisible = false;
			BuyersListTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			BuyersListTable.Size = new Size(1108, 811);
			BuyersListTable.TabIndex = 56;
			// 
			// BtnCancel
			// 
			BtnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnCancel.Image = Properties.Resources.icons8_close_window_20;
			BtnCancel.ImageAlign = ContentAlignment.MiddleLeft;
			BtnCancel.Location = new Point(1221, 492);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(94, 32);
			BtnCancel.TabIndex = 53;
			BtnCancel.Text = "Cancel";
			BtnCancel.TextAlign = ContentAlignment.MiddleRight;
			BtnCancel.UseVisualStyleBackColor = true;
			BtnCancel.Click += BtnCancel_Click;
			// 
			// BtnDelete
			// 
			BtnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnDelete.Image = Properties.Resources.icons8_remove_22;
			BtnDelete.ImageAlign = ContentAlignment.MiddleLeft;
			BtnDelete.Location = new Point(1332, 492);
			BtnDelete.Name = "BtnDelete";
			BtnDelete.Size = new Size(94, 32);
			BtnDelete.TabIndex = 54;
			BtnDelete.Text = "Delete";
			BtnDelete.TextAlign = ContentAlignment.MiddleRight;
			BtnDelete.UseVisualStyleBackColor = true;
			BtnDelete.Visible = false;
			// 
			// BtnModify
			// 
			BtnModify.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BtnModify.Image = Properties.Resources.icons8_add_241;
			BtnModify.ImageAlign = ContentAlignment.MiddleLeft;
			BtnModify.Location = new Point(1443, 492);
			BtnModify.Name = "BtnModify";
			BtnModify.Size = new Size(94, 32);
			BtnModify.TabIndex = 55;
			BtnModify.Text = "Create";
			BtnModify.TextAlign = ContentAlignment.MiddleRight;
			BtnModify.UseVisualStyleBackColor = true;
			BtnModify.Click += BtnModify_Click;
			// 
			// panel4
			// 
			panel4.Controls.Add(RichAddress);
			panel4.Controls.Add(label6);
			panel4.Location = new Point(1183, 249);
			panel4.Name = "panel4";
			panel4.Size = new Size(387, 204);
			panel4.TabIndex = 44;
			// 
			// RichAddress
			// 
			RichAddress.BorderStyle = BorderStyle.FixedSingle;
			RichAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			RichAddress.Location = new Point(3, 23);
			RichAddress.Name = "RichAddress";
			RichAddress.ScrollBars = RichTextBoxScrollBars.Horizontal;
			RichAddress.Size = new Size(381, 178);
			RichAddress.TabIndex = 2;
			RichAddress.Text = "";
			RichAddress.TextChanged += RichAddress_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(3, 0);
			label6.Name = "label6";
			label6.Size = new Size(62, 20);
			label6.TabIndex = 1;
			label6.Text = "Address";
			// 
			// panel3
			// 
			panel3.Controls.Add(Phone);
			panel3.Controls.Add(label5);
			panel3.Location = new Point(1183, 189);
			panel3.Name = "panel3";
			panel3.Size = new Size(387, 54);
			panel3.TabIndex = 45;
			// 
			// Phone
			// 
			Phone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Phone.Location = new Point(3, 23);
			Phone.Name = "Phone";
			Phone.Size = new Size(381, 27);
			Phone.TabIndex = 1;
			Phone.TextChanged += Phone_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(3, 0);
			label5.Name = "label5";
			label5.Size = new Size(108, 20);
			label5.TabIndex = 1;
			label5.Text = "Phone Number";
			// 
			// panel2
			// 
			panel2.Controls.Add(BuyerName);
			panel2.Controls.Add(label4);
			panel2.Location = new Point(1183, 129);
			panel2.Name = "panel2";
			panel2.Size = new Size(387, 54);
			panel2.TabIndex = 43;
			// 
			// BuyerName
			// 
			BuyerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BuyerName.Location = new Point(3, 23);
			BuyerName.Name = "BuyerName";
			BuyerName.Size = new Size(381, 27);
			BuyerName.TabIndex = 1;
			BuyerName.TextChanged += BuyerName_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(3, 0);
			label4.Name = "label4";
			label4.Size = new Size(99, 20);
			label4.TabIndex = 1;
			label4.Text = "Buyer's Name";
			// 
			// panel1
			// 
			panel1.Controls.Add(BuyerId);
			panel1.Controls.Add(label3);
			panel1.Location = new Point(1183, 69);
			panel1.Name = "panel1";
			panel1.Size = new Size(387, 54);
			panel1.TabIndex = 52;
			// 
			// BuyerId
			// 
			BuyerId.BackColor = SystemColors.Window;
			BuyerId.Enabled = false;
			BuyerId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BuyerId.Location = new Point(3, 23);
			BuyerId.Name = "BuyerId";
			BuyerId.ReadOnly = true;
			BuyerId.Size = new Size(164, 27);
			BuyerId.TabIndex = 1;
			BuyerId.TextAlign = HorizontalAlignment.Center;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(3, 0);
			label3.Name = "label3";
			label3.Size = new Size(63, 20);
			label3.TabIndex = 1;
			label3.Text = "Buyer Id";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_username_24;
			pictureBox1.Location = new Point(1183, 29);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(24, 24);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 51;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(1213, 29);
			label1.Name = "label1";
			label1.Size = new Size(137, 21);
			label1.TabIndex = 50;
			label1.Text = "Add-Modify Buyer";
			// 
			// button1
			// 
			button1.Location = new Point(1170, 17);
			button1.Name = "button1";
			button1.Size = new Size(415, 547);
			button1.TabIndex = 49;
			button1.UseVisualStyleBackColor = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.icons8_table_20;
			pictureBox2.Location = new Point(28, 29);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(20, 20);
			pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox2.TabIndex = 48;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(58, 29);
			label2.Name = "label2";
			label2.Size = new Size(78, 21);
			label2.TabIndex = 47;
			label2.Text = "Buyer List";
			// 
			// button7
			// 
			button7.Location = new Point(15, 17);
			button7.Name = "button7";
			button7.Size = new Size(1134, 937);
			button7.TabIndex = 46;
			button7.UseVisualStyleBackColor = false;
			// 
			// BuyerNameRequire
			// 
			BuyerNameRequire.ContainerControl = this;
			// 
			// PhoneRequire
			// 
			PhoneRequire.ContainerControl = this;
			// 
			// AddressRequire
			// 
			AddressRequire.ContainerControl = this;
			// 
			// Buyer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(BuyersRows);
			Controls.Add(SearchField);
			Controls.Add(BuyersListTable);
			Controls.Add(BtnCancel);
			Controls.Add(BtnDelete);
			Controls.Add(BtnModify);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(pictureBox2);
			Controls.Add(label2);
			Controls.Add(button7);
			Name = "Buyer";
			Size = new Size(1600, 970);
			((System.ComponentModel.ISupportInitialize)BuyersListTable).EndInit();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)BuyerNameRequire).EndInit();
			((System.ComponentModel.ISupportInitialize)PhoneRequire).EndInit();
			((System.ComponentModel.ISupportInitialize)AddressRequire).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label BuyersRows;
		private TextBox SearchField;
		private DataGridView BuyersListTable;
		private Button BtnCancel;
		private Button BtnDelete;
		private Button BtnModify;
		private Panel panel4;
		private RichTextBox RichAddress;
		private Label label6;
		private Panel panel3;
		public TextBox Phone;
		private Label label5;
		private Panel panel2;
		public TextBox BuyerName;
		private Label label4;
		private Panel panel1;
		public TextBox BuyerId;
		private Label label3;
		private PictureBox pictureBox1;
		private Label label1;
		private Button button1;
		private PictureBox pictureBox2;
		private Label label2;
		private Button button7;
		private ErrorProvider BuyerNameRequire;
		private ErrorProvider PhoneRequire;
		private ErrorProvider AddressRequire;
	}
}
