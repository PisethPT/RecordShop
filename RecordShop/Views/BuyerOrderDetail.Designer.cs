namespace RecordShop.Views
{
	partial class BuyerOrderDetail
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
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			button7 = new Button();
			BuyersRows = new Label();
			OrderHistoryListTable = new DataGridView();
			button1 = new Button();
			Payable = new Label();
			Remain = new Label();
			Subtotal = new Label();
			OrderDate = new Label();
			label11 = new Label();
			BuyerName = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)OrderHistoryListTable).BeginInit();
			SuspendLayout();
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.icons8_order_241;
			pictureBox2.Location = new Point(14, 13);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(24, 24);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 14;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(44, 13);
			label2.Name = "label2";
			label2.Size = new Size(102, 21);
			label2.TabIndex = 13;
			label2.Text = "Order Details";
			// 
			// button7
			// 
			button7.Location = new Point(1, 1);
			button7.Name = "button7";
			button7.Size = new Size(681, 408);
			button7.TabIndex = 12;
			button7.UseVisualStyleBackColor = false;
			// 
			// BuyersRows
			// 
			BuyersRows.AutoSize = true;
			BuyersRows.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BuyersRows.Location = new Point(14, 377);
			BuyersRows.Name = "BuyersRows";
			BuyersRows.Size = new Size(70, 20);
			BuyersRows.TabIndex = 66;
			BuyersRows.Text = "Rows: 0.0";
			// 
			// OrderHistoryListTable
			// 
			OrderHistoryListTable.AllowUserToAddRows = false;
			OrderHistoryListTable.AllowUserToDeleteRows = false;
			OrderHistoryListTable.AllowUserToResizeRows = false;
			OrderHistoryListTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			OrderHistoryListTable.BackgroundColor = SystemColors.Window;
			OrderHistoryListTable.BorderStyle = BorderStyle.None;
			OrderHistoryListTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			OrderHistoryListTable.DefaultCellStyle = dataGridViewCellStyle2;
			OrderHistoryListTable.GridColor = SystemColors.Window;
			OrderHistoryListTable.Location = new Point(13, 145);
			OrderHistoryListTable.MultiSelect = false;
			OrderHistoryListTable.Name = "OrderHistoryListTable";
			OrderHistoryListTable.ReadOnly = true;
			OrderHistoryListTable.RowHeadersVisible = false;
			OrderHistoryListTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			OrderHistoryListTable.Size = new Size(658, 218);
			OrderHistoryListTable.TabIndex = 65;
			// 
			// button1
			// 
			button1.Location = new Point(12, 56);
			button1.Name = "button1";
			button1.Size = new Size(659, 83);
			button1.TabIndex = 68;
			button1.UseVisualStyleBackColor = false;
			// 
			// Payable
			// 
			Payable.AutoSize = true;
			Payable.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Payable.Location = new Point(206, 107);
			Payable.Name = "Payable";
			Payable.Size = new Size(104, 20);
			Payable.TabIndex = 69;
			Payable.Text = "Total Payable: ";
			// 
			// Remain
			// 
			Remain.AutoSize = true;
			Remain.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Remain.Location = new Point(463, 107);
			Remain.Name = "Remain";
			Remain.Size = new Size(66, 20);
			Remain.TabIndex = 70;
			Remain.Text = "Remain: ";
			// 
			// Subtotal
			// 
			Subtotal.AutoSize = true;
			Subtotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Subtotal.Location = new Point(33, 107);
			Subtotal.Name = "Subtotal";
			Subtotal.Size = new Size(72, 20);
			Subtotal.TabIndex = 71;
			Subtotal.Text = "Subtotal: ";
			// 
			// OrderDate
			// 
			OrderDate.AutoSize = true;
			OrderDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			OrderDate.Location = new Point(463, 69);
			OrderDate.Name = "OrderDate";
			OrderDate.Size = new Size(90, 20);
			OrderDate.TabIndex = 72;
			OrderDate.Text = "Order Date: ";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label11.Location = new Point(33, 69);
			label11.Name = "label11";
			label11.Size = new Size(106, 20);
			label11.TabIndex = 73;
			label11.Text = "Buyer's Name: ";
			// 
			// BuyerName
			// 
			BuyerName.AutoSize = true;
			BuyerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			BuyerName.Location = new Point(145, 69);
			BuyerName.Name = "BuyerName";
			BuyerName.Size = new Size(88, 21);
			BuyerName.TabIndex = 73;
			BuyerName.Text = "Jonh Dom";
			// 
			// BuyerOrderDetail
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			ClientSize = new Size(683, 410);
			Controls.Add(Payable);
			Controls.Add(Remain);
			Controls.Add(Subtotal);
			Controls.Add(OrderDate);
			Controls.Add(BuyerName);
			Controls.Add(label11);
			Controls.Add(button1);
			Controls.Add(BuyersRows);
			Controls.Add(OrderHistoryListTable);
			Controls.Add(pictureBox2);
			Controls.Add(label2);
			Controls.Add(button7);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "BuyerOrderDetail";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Buyer Order Detail";
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)OrderHistoryListTable).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox2;
		private Label label2;
		private Button button7;
		private Label BuyersRows;
		private DataGridView OrderHistoryListTable;
		private Button button1;
		private Label Payable;
		private Label Remain;
		private Label Subtotal;
		private Label OrderDate;
		private Label label11;
		private Label BuyerName;
	}
}