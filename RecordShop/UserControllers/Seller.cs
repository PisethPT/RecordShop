using Microsoft.EntityFrameworkCore;
using RecordShop.Data;
using System.Data;

namespace RecordShop.UserControllers
{
	public partial class Seller : UserControl
	{
		private VinylRecordsContext context;
		private int sellerId;
		public Seller()
		{
			InitializeComponent();
			context = new VinylRecordsContext();

			GetAllSellers(context.Sellers.ToList());


			this.BtnDelete.Enabled = false;
			this.BtnModify.Text = "Create";
		}

		private void GetAllSellers(List<Models.Seller> sellers)
		{
			if (context.Sellers.Count() > 0)
				sellerId = context.Sellers.OrderByDescending(s => s.SellerId).FirstOrDefault()!.SellerId + 1;
			else
				sellerId = 1;
			this.SellerId.Text = sellerId.ToString();

			DataTable table = new DataTable();
			table.Columns.Add("No.");
			table.Columns.Add("Seller's Name");
			table.Columns.Add("Phone Number");
			table.Columns.Add("Address");
			table.Columns.Add("Created Date");

			foreach (Models.Seller seller in sellers)
			{
				var row = table.NewRow();
				row[0] = seller.SellerId;
				row[1] = seller.SellerName;
				row[2] = seller.Phone;
				row[3] = seller.Address;
				row[4] = seller.Created?.ToShortDateString();

				table.Rows.Add(row);
			}

			this.SellersListTable.DataSource = table;
			this.SellersListTable.CellClick += SellersListTable_CellClick;

			this.SellersListTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.SellersListTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.SellersListTable.Columns["Phone Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.SellersListTable.Columns["Created Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

			this.SellerslRows.Text = $"Rows: {sellers.Count.ToString("#,###.0")}";
		}

		private void SellersListTable_CellClick(object? sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				this.SellerId.Text = this.SellersListTable.Rows[e.RowIndex].Cells[0].Value.ToString();
				this.SellerName.Text = this.SellersListTable.Rows[e.RowIndex].Cells[1].Value.ToString();
				this.Phone.Text = this.SellersListTable.Rows[e.RowIndex].Cells[2].Value.ToString();
				this.RichAddress.Text = this.SellersListTable.Rows[e.RowIndex].Cells[3].Value.ToString();

				this.BtnDelete.Enabled = true;
				this.BtnModify.Text = "Update";
			}
		}

		private void BtnModify_Click(object sender, EventArgs e)
		{
			var seller = new Models.Seller();
			if (string.IsNullOrEmpty(this.SellerName.Text) || string.IsNullOrWhiteSpace(this.SellerName.Text))
			{
				this.SellerNameRequire.SetError(this.SellerName, "Seller's name require.");
				return;
			}
			else
			{
				seller.SellerName = this.SellerName.Text;
			}

			if (string.IsNullOrEmpty(this.Phone.Text) || string.IsNullOrWhiteSpace(this.Phone.Text))
			{
				this.PhoneRequire.SetError(this.Phone, "Phone number is require.");
				return;
			}
			else
			{
				seller.Phone = this.Phone.Text;
			}

			if (string.IsNullOrEmpty(this.RichAddress.Text) || string.IsNullOrWhiteSpace(this.RichAddress.Text))
			{
				this.AddressRequire.SetError(this.RichAddress, "Address is require.");
				return;
			}
			else
			{
				seller.Address = this.RichAddress.Text;
			}
			sellerId = int.Parse(this.SellerId.Text);
			seller.SellerId = sellerId;
			seller.Updated = DateTime.Now;

			if (this.BtnModify.Text == "Create")
			{
				seller.Created = DateTime.Now;
				context.Sellers.Add(seller);
				context.SaveChanges();
			}
			else if (this.BtnModify.Text == "Update")
			{
				var existingSeller = context.Sellers.FirstOrDefault(s => s.SellerId == sellerId);
				if (existingSeller != null)
				{
					var created = existingSeller.Created;
					context.Entry(existingSeller).State = EntityState.Detached;
					existingSeller = seller;
					existingSeller.Created = created;
					context.Sellers.Update(existingSeller);
					context.SaveChanges();
				}
			}

			CancelFields();
			GetAllSellers(context.Sellers.ToList());
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{

		}

		private void BtnCancel_Click(object sender, EventArgs e) => CancelFields();

		private void CancelFields()
		{
			this.SellerId.Text = sellerId.ToString();
			this.SellerName.Text = string.Empty;
			this.Phone.Text = string.Empty;
			this.RichAddress.Text = string.Empty;

			this.BtnDelete.Enabled = false;
			this.BtnModify.Text = "Create";

			this.SellersListTable.ClearSelection();
		}

		private void SearchField_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.SearchField.Text) || string.IsNullOrWhiteSpace(this.SearchField.Text))
				GetAllSellers(context.Sellers.ToList());
			else
			{
				var sellers = context.Sellers.Where(s => s.SellerName.ToLower().StartsWith(this.SearchField.Text.ToLower())).ToList();
				GetAllSellers(sellers);
			}
		}

		private void SellerName_TextChanged(object sender, EventArgs e) => this.SellerNameRequire.SetError(this.SellerName, "Seller's name require.");

		private void Phone_TextChanged(object sender, EventArgs e) => this.PhoneRequire.SetError(this.Phone, string.Empty);

		private void RichAddress_TextChanged(object sender, EventArgs e) => this.AddressRequire.SetError(this.RichAddress, string.Empty);
	}
}
