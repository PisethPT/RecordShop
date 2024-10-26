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

			this.SellerId.Text = sellerId.ToString();
			this.BtnDelete.Enabled = false;
			this.BtnModify.Text = "Create";
		}

		private void GetAllSellers(List<Models.Seller> sellers)
		{
			if (context.Sellers.Count() > 0)
				sellerId = context.Sellers.OrderByDescending(s => s.SellerId).FirstOrDefault()!.SellerId + 1;
			else
				sellerId = 1;

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
			seller.SellerId = sellerId;
			if (string.IsNullOrEmpty(this.SellerName.Text) || string.IsNullOrWhiteSpace(this.SellerName.Text))
			{
				return;
			}
			else
			{
				seller.SellerName = this.SellerName.Text;
			}

			if (string.IsNullOrEmpty(this.Phone.Text) || string.IsNullOrWhiteSpace(this.Phone.Text))
			{
				return;
			}
			else
			{
				seller.Phone = this.Phone.Text;
			}

			if (string.IsNullOrEmpty(this.RichAddress.Text) || string.IsNullOrWhiteSpace(this.RichAddress.Text))
			{
				return;
			}
			else
			{
				seller.Address = this.RichAddress.Text;
			}

			seller.Created = DateTime.Now;
			seller.Updated = DateTime.Now;
			context.Sellers.Add(seller);
			context.SaveChanges();
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

		private void Seller_Load(object sender, EventArgs e)
		{

		}
	}
}
