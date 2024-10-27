namespace RecordShop.UserControllers
{
	partial class OrderHistory
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
			BuyersRows = new Label();
			SearchField = new TextBox();
			OrderHistoryListTable = new DataGridView();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			button7 = new Button();
			((System.ComponentModel.ISupportInitialize)OrderHistoryListTable).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// BuyersRows
			// 
			BuyersRows.AutoSize = true;
			BuyersRows.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BuyersRows.Location = new Point(25, 916);
			BuyersRows.Name = "BuyersRows";
			BuyersRows.Size = new Size(70, 20);
			BuyersRows.TabIndex = 64;
			BuyersRows.Text = "Rows: 0.0";
			// 
			// SearchField
			// 
			SearchField.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SearchField.Location = new Point(194, 58);
			SearchField.Multiline = true;
			SearchField.Name = "SearchField";
			SearchField.PlaceholderText = "Search By Name";
			SearchField.Size = new Size(476, 28);
			SearchField.TabIndex = 63;
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
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Window;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
			OrderHistoryListTable.DefaultCellStyle = dataGridViewCellStyle1;
			OrderHistoryListTable.GridColor = SystemColors.Window;
			OrderHistoryListTable.Location = new Point(25, 102);
			OrderHistoryListTable.MultiSelect = false;
			OrderHistoryListTable.Name = "OrderHistoryListTable";
			OrderHistoryListTable.ReadOnly = true;
			OrderHistoryListTable.RowHeadersVisible = false;
			OrderHistoryListTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			OrderHistoryListTable.Size = new Size(1548, 811);
			OrderHistoryListTable.TabIndex = 62;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.icons8_table_20;
			pictureBox2.Location = new Point(25, 25);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(20, 20);
			pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox2.TabIndex = 61;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(55, 25);
			label2.Name = "label2";
			label2.Size = new Size(114, 21);
			label2.TabIndex = 60;
			label2.Text = "Orders Archive";
			// 
			// button7
			// 
			button7.Location = new Point(12, 13);
			button7.Name = "button7";
			button7.Size = new Size(1574, 937);
			button7.TabIndex = 59;
			button7.UseVisualStyleBackColor = false;
			// 
			// OrderHistory
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(BuyersRows);
			Controls.Add(SearchField);
			Controls.Add(OrderHistoryListTable);
			Controls.Add(pictureBox2);
			Controls.Add(label2);
			Controls.Add(button7);
			Name = "OrderHistory";
			Size = new Size(1600, 970);
			((System.ComponentModel.ISupportInitialize)OrderHistoryListTable).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label BuyersRows;
		private TextBox SearchField;
		private DataGridView OrderHistoryListTable;
		private PictureBox pictureBox2;
		private Label label2;
		private Button button7;
	}
}
