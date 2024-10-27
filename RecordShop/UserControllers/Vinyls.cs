using Microsoft.EntityFrameworkCore;
using RecordShop.Data;
using RecordShop.Models;
using RecordShop.Statics;
using RecordShop.Views;
using System.Data;


namespace RecordShop.UserControllers
{
	public partial class Vinyls : UserControl
	{
		private VinylRecordsContext context;
		private int vinylDiscountId;
		string iconDirectoryPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "Images");
		public Vinyls()
		{
			InitializeComponent();

			if (this is not null)
				StaticComponents.SearchField = this.SearchField;

			context = new VinylRecordsContext();
			this.SearchType.SelectedIndex = 0;
			context.Vinyls.ToList();
			GetAllVinylRecords(context.Vinyls.ToList());
			GetAllVinylDiscount();
			this.BtnSubmit.Enabled = false;
			this.BtnReturn.Visible = false;
			this.BtnSubmit.Text = "Create";
			CheckExpireDiscountDate();
		}

		private void GetAllVinylDiscount()
		{
			int index = 1;
			if (context.VinylForDiscounts.Count() > 0)
				vinylDiscountId = context.VinylForDiscounts.OrderByDescending(x => x.Id).FirstOrDefault()!.Id + 1;
			else vinylDiscountId = 1;

			var vinylDiscount = context.VinylForDiscounts.Where(d => d.DiscountDate!.Date.Equals(DateTime.Today) || d.DiscountDate!.Date > DateTime.Today)
														 .OrderByDescending(d => d.DiscountDate).ToList();
			vinylDiscount.Reverse();
			DataTable table = new DataTable();
			table.Columns.Add("No.");
			table.Columns.Add("Vinyl Name");
			table.Columns.Add("Discount Date");
			table.Columns.Add("Sale Price");

			foreach (var vinyl in vinylDiscount)
			{
				var row = table.NewRow();
				row[0] = index++;
				row[1] = context.Vinyls.Where(v => v.VinylId == vinyl.VinylId).FirstOrDefault()!.VinylName;
				row[2] = vinyl.DiscountDate.ToShortDateString();
				row[3] = vinyl.SellingPrice.ToString("$#,###.00");

				table.Rows.Add(row);
			}

			this.VinylDiscountTable.DataSource = table;
			this.VinylDiscountTable.CellClick += VinylDiscountTable_CellClick;

			this.VinylDiscountTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.VinylDiscountTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.VinylDiscountTable.Columns["Sale Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.VinylDiscountTable.Columns["Discount Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.DiscountVinylRows.Text = $"Rows: {table.Rows.Count.ToString("#,###.0")}";
		}

		private void VinylDiscountTable_CellClick(object? sender, DataGridViewCellEventArgs e) => CancelAndResetField();

		private void GetAllVinylRecords(List<Vinyl> vinylRecords)
		{
			DataTable table = new DataTable();
			table.Columns.Add("No.");
			table.Columns.Add("Vinyl Name");
			table.Columns.Add("Band Name");
			table.Columns.Add("Genre");
			table.Columns.Add("Publisher Name");
			table.Columns.Add("Num Track");
			table.Columns.Add("Date Publish");
			table.Columns.Add("Prime Cost");
			table.Columns.Add("Sale Price");

			foreach (var vinyl in vinylRecords)
			{
				var row = table.NewRow();
				row[0] = vinyl.VinylId;
				row[1] = vinyl.VinylName;
				row[2] = context.Bands.Where(b => b.BandId == vinyl.BandId).FirstOrDefault()!.BandName;
				row[3] = context.Genres.Where(g => g.GenreId == vinyl.Band!.GenreId).FirstOrDefault()!.GenreName;
				row[4] = context.Publishers.Where(p => p.PublisherId == vinyl.PublisherId).FirstOrDefault()!.Name;
				row[5] = vinyl.NumberOfTrack;
				row[6] = vinyl.DateOfPublishing?.ToShortDateString();
				row[7] = vinyl.PrimeCost.ToString("$#,###.00");
				row[8] = vinyl.SalePrice.ToString("$#,###.00");

				table.Rows.Add(row);
			}

			this.AllVinylRecordsTable.DataSource = table;

			try
			{
				if (!this.AllVinylRecordsTable.Columns[0].HeaderText.Equals("Edit") && !this.AllVinylRecordsTable.Columns[1].HeaderText.Equals("Delete"))
				{
					DataGridViewImageColumn edit = new DataGridViewImageColumn();
					edit.HeaderText = "Edit";
					edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
					edit.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "icons8-edit-24-1.png")), new Size(20, 20));
					this.AllVinylRecordsTable.Columns.Add(edit);

					DataGridViewImageColumn delete = new DataGridViewImageColumn();
					delete.HeaderText = "Delete";
					delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
					delete.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "icons8-delete-24.png")), new Size(20, 20));
					this.AllVinylRecordsTable.Columns.Add(delete);

					TableColumnFormat(this.AllVinylRecordsTable);
					this.AllVinylRecordsTable.CellClick += AllVinylRecordsTable_CellClick;
					this.VinylDiscountTable.CellDoubleClick += VinylDiscountTable_CellDoubleClick;
					this.AllVinylRows.Text = $"Rows: {vinylRecords.Count.ToString("#,###.0")}";

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void VinylDiscountTable_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				this.VinylName.Text = this.VinylDiscountTable.Rows[e.RowIndex].Cells[1].Value.ToString();
				this.SellingPrice.Value = decimal.Parse(this.VinylDiscountTable.Rows[e.RowIndex].Cells[3].Value.ToString()!.Trim('$'));
				this.DiscountDate.Text = this.VinylDiscountTable.Rows[e.RowIndex].Cells[2].Value.ToString();
				this.BtnReturn.Visible = true;
				this.BtnSubmit.Enabled = true;
				this.BtnSubmit.Text = "Update";
			}
		}

		private void TableColumnFormat(DataGridView gridView)
		{
			gridView.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			gridView.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			gridView.Columns["Num Track"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns["Num Track"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			gridView.Columns["Prime Cost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			gridView.Columns["Sale Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			gridView.Columns["Date Publish"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			gridView.Columns["Genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}

		private void AllVinylRecordsTable_CellClick(object? sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				var vinylId = int.Parse(this.AllVinylRecordsTable.Rows[e.RowIndex].Cells[2].Value.ToString()!);
				var vinylName = this.AllVinylRecordsTable.Rows[e.RowIndex].Cells[3].Value.ToString();
				var sellingPrice = decimal.Parse(this.AllVinylRecordsTable.Rows[e.RowIndex].Cells[10].Value.ToString()!.Trim('$'));
				sellingPrice -= (sellingPrice * 10) / 100;
				this.VinylName.Text = vinylName;
				this.SellingPrice.Value = sellingPrice;
				this.BtnSubmit.Enabled = true;
			}

			if (this.AllVinylRecordsTable.Columns[e.ColumnIndex].HeaderText.Equals("Edit") && e.RowIndex >= 0)
			{
				EditVinyl(e.RowIndex);
			}
			else if (this.AllVinylRecordsTable.Columns[e.ColumnIndex].HeaderText.Equals("Delete") && e.RowIndex >= 0)
			{
				DeleteVinyl(e.RowIndex);
			}
		}

		private void BtnNewVinyl_Click(object sender, EventArgs e) => new ModifyVinyl().ShowDialog();

		private void SearchType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.SearchType.SelectedIndex == 0)
				this.SearchField.PlaceholderText = "Search By Name";
			if (this.SearchType.SelectedIndex == 1)
				this.SearchField.PlaceholderText = "Search By Band";
			if (this.SearchType.SelectedIndex == 2)
				this.SearchField.PlaceholderText = "Search By Genre";
		}

		private void SearchField_TextChanged(object sender, EventArgs e) => SearchingVinyl(this.SearchType.SelectedIndex);

		private void SearchingVinyl(int searchType)
		{
			if (searchType == 0)
			{
				if (!string.IsNullOrEmpty(this.SearchField.Text) || !string.IsNullOrWhiteSpace(this.SearchField.Text))
				{
					var vinyl = context.Vinyls.Where(v => v.VinylName.ToLower().StartsWith(this.SearchField.Text.ToLower())).ToList();
					GetAllVinylRecords(vinyl);
				}
				else
					GetAllVinylRecords(context.Vinyls.ToList());
			}
			else if (searchType == 1)
			{
				if (!string.IsNullOrEmpty(this.SearchField.Text) || !string.IsNullOrWhiteSpace(this.SearchField.Text))
				{
					var vinyl = context.Vinyls.Where(v => v.Band!.BandName.ToLower().StartsWith(this.SearchField.Text.ToLower())).ToList();
					GetAllVinylRecords(vinyl);
				}
				else
					GetAllVinylRecords(context.Vinyls.ToList());
			}
			else if (searchType == 2)
			{
				if (!string.IsNullOrEmpty(this.SearchField.Text) || !string.IsNullOrWhiteSpace(this.SearchField.Text))
				{
					var vinyl = context.Vinyls.Where(v => v.Band!.Genre!.GenreName.ToLower().StartsWith(this.SearchField.Text.ToLower())).ToList();
					GetAllVinylRecords(vinyl);
				}
				else
					GetAllVinylRecords(context.Vinyls.ToList());
			}
		}

		private void BtnSubmit_Click(object sender, EventArgs e)
		{
			if (this.BtnSubmit.Text == "Create")
				AddDiscountVinyl();
			else if (this.BtnSubmit.Text == "Update")
				UpdateDiscountVinyl();
		}

		private void UpdateDiscountVinyl()
		{
			var vinylId = context.Vinyls.FirstOrDefault(v => v.VinylName.Equals(this.VinylName.Text))!.VinylId;
			if (vinylId > 0)
			{
				var vinylDiscount = context.VinylForDiscounts.FirstOrDefault(d => d.VinylId == vinylId);
				if (vinylDiscount != null)
				{
					vinylDiscount.DiscountDate = this.DiscountDate.Value;
					vinylDiscount.SellingPrice = (double)this.SellingPrice.Value;
					vinylDiscount.Updated = DateTime.Now;
					context.Entry(vinylDiscount).State = EntityState.Detached;
					context.VinylForDiscounts.Update(vinylDiscount);
					context.SaveChanges();
					CancelAndResetField();
					GetAllVinylDiscount();
				}
			}
		}

		private void BtnCancel_Click(object sender, EventArgs e) => CancelAndResetField();

		private void CancelAndResetField()
		{
			this.VinylName.Text = string.Empty;
			this.SellingPrice.Value = 0;
			this.DiscountDate.Value = DateTime.Now;
			this.AllVinylRecordsTable.ClearSelection();
			this.BtnSubmit.Enabled = false;
			this.BtnSubmit.Text = "Create";
			this.BtnReturn.Visible = false;
		}

		private void AddDiscountVinyl()
		{
			var vinylForDiscount = new VinylForDiscount();
			vinylForDiscount.Id = vinylDiscountId;
			if (string.IsNullOrEmpty(this.VinylName.Text) || string.IsNullOrWhiteSpace(this.VinylName.Text))
			{
				return;
			}
			else
			{
				vinylForDiscount.VinylId = context.Vinyls.Where(v => v.VinylName.Equals(this.VinylName.Text)).FirstOrDefault()!.VinylId;
			}

			if (this.DiscountDate.Value < DateTime.Now)
				return;
			else
			vinylForDiscount.DiscountDate = this.DiscountDate.Value;

			//vinylForDiscount.SellingPrice = (double)this.SellingPrice.Value;
			var sellingPriceDiscount = (double)context.Vinyls.Where(v => v.VinylName.Equals(this.VinylName.Text)).FirstOrDefault()!.SalePrice;
			sellingPriceDiscount -= (sellingPriceDiscount * 10) / 100;
			vinylForDiscount.SellingPrice = sellingPriceDiscount;
			vinylForDiscount.Created = DateTime.Now;
			vinylForDiscount.Updated = DateTime.Now;

			var response = context.VinylForDiscounts.Where(v => v.Vinyl!.VinylName == this.VinylName.Text).FirstOrDefault();
			if (response is null)
			{
				context.VinylForDiscounts.Add(vinylForDiscount);
				context.SaveChanges();
				UpdateVinylStatusWhenAddOrReturnDiscount(vinylForDiscount.VinylId.Value, 0);

				CancelAndResetField();
				GetAllVinylDiscount();
			}
			else
			{
				MessageBox.Show("Vinyl Already Discount.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				CancelAndResetField();
				return;
			}
		}

		public void UpdateVinylStatusWhenAddOrReturnDiscount(int vinylId, byte statusCode)
		{
			var vinyl = context.Vinyls.FirstOrDefault(v => v.VinylId == vinylId);
			if (vinyl != null)
			{
				vinyl.Status = statusCode;
				context.Entry(vinyl).State = EntityState.Detached;
				context.Vinyls.Update(vinyl);
				context.SaveChanges();
			}
		}

		private void EditVinyl(int rowIndex)
		{
			using (var vinyl = new ModifyVinyl())
			{
				try
				{
					vinyl.Tittle.Text = "Update Vinyl";
					vinyl.VinylId.Text = this.AllVinylRecordsTable.Rows[rowIndex].Cells[2].Value.ToString();
					vinyl.VinylName.Text = this.AllVinylRecordsTable.Rows[rowIndex].Cells[3].Value.ToString();
					vinyl.CbChooseBand.SelectedIndex = context.Bands.Where(b => b.BandName == this.AllVinylRecordsTable.Rows[rowIndex].Cells[4].Value.ToString()).FirstOrDefault()!.BandId - 1;
					vinyl.CbChoosePublisher.SelectedIndex = context.Publishers.Where(p => p.Name == this.AllVinylRecordsTable.Rows[rowIndex].Cells[6].Value.ToString()).FirstOrDefault()!.PublisherId - 1;
					vinyl.NumberOfTrack.Text = this.AllVinylRecordsTable.Rows[rowIndex].Cells[7].Value.ToString();
					vinyl.DateOfPublishing.Text = this.AllVinylRecordsTable.Rows[rowIndex].Cells[8].Value.ToString();
					vinyl.PrimeCost.Text = this.AllVinylRecordsTable.Rows[rowIndex].Cells[9].Value.ToString()!.Trim('$');
					vinyl.SalePrice.Text = this.AllVinylRecordsTable.Rows[rowIndex].Cells[10].Value.ToString()!.Trim('$');

					vinyl.BtnModify.Text = "Update";

					vinyl.ShowDialog();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void DeleteVinyl(int rowIndex)
		{
			var vinylIndex = int.Parse(this.AllVinylRecordsTable.Rows[rowIndex].Cells[2].Value.ToString()!);
			var vinyl = context.Vinyls.FirstOrDefault(v => v.VinylId.Equals(vinylIndex));
			if (vinyl is not null)
			{
				var response = MessageBox.Show($"Delete this '{this.AllVinylRecordsTable.Rows[rowIndex].Cells[3].Value.ToString()}' ?", "Delete Vinyl", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (response == DialogResult.OK)
				{
					try
					{
						var vinylDiscount = context.VinylForDiscounts.Where(c => c.VinylId.Equals(vinyl.VinylId)).FirstOrDefault();
						if (vinylDiscount is not null)
						{

							context.VinylForDiscounts.Remove(vinylDiscount);
							context.SaveChanges();
						}

						context.Vinyls.Remove(vinyl);
						context.SaveChanges();

						MessageBox.Show("Deleted.");
						GetAllVinylRecords(context.Vinyls.ToList());
						GetAllVinylDiscount();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		private void VinylDiscountReturnToNormalPrice(int vinylId)
		{
			var existingVinylDiscount = context.VinylForDiscounts.FirstOrDefault(d => d.VinylId == vinylId);
			if (existingVinylDiscount is not null)
			{
				context.VinylForDiscounts.Remove(existingVinylDiscount);
				context.SaveChanges();
				UpdateVinylStatusWhenAddOrReturnDiscount(vinylId, 1);
			}
		}

		private void CheckExpireDiscountDate()
		{
			foreach (var vinyl in context.VinylForDiscounts.Where(d => d.DiscountDate!.Date < DateTime.Today).ToList())
			{
				VinylDiscountReturnToNormalPrice(vinyl.VinylId!.Value);
			}
		}

		private void BtnReturn_Click(object sender, EventArgs e)
		{
			var vinylId = context.Vinyls.FirstOrDefault(v => v.VinylName.Equals(this.VinylName.Text))!.VinylId;
			if(vinylId > 0)
				VinylDiscountReturnToNormalPrice(vinylId);

			CancelAndResetField();
			GetAllVinylDiscount();
		}

	}
}
