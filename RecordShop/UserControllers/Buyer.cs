using Microsoft.EntityFrameworkCore;
using RecordShop.Data;
using System.Data;

namespace RecordShop.UserControllers
{
	public partial class Buyer : UserControl
	{
		private VinylRecordsContext context;
		private int buyerId = 0;
		public Buyer()
		{
			InitializeComponent();
			context = new VinylRecordsContext();
			GetAllBuyers(context.Buyers.ToList());
		}

		private void GetAllBuyers(List<Models.Buyer> buyers)
		{
			if (context.Buyers.Count() > 0)
				buyerId = context.Buyers.OrderByDescending(b => b.BuyerId).FirstOrDefault()!.BuyerId + 1;
			else
				buyerId = 1;
			this.BuyerId.Text = buyerId.ToString();
			DataTable table = new DataTable();
			table.Columns.Add("No.");
			table.Columns.Add("Buyer's Name");
			table.Columns.Add("Phone Number");
			table.Columns.Add("Address");
			table.Columns.Add("Created Date");

			foreach (Models.Buyer buyer in buyers)
			{
				var row = table.NewRow();
				row[0] = buyer.BuyerId;
				row[1] = buyer.BuyerName;
				row[2] = buyer.Phone;
				row[3] = buyer.Address;
				row[4] = buyer.Created?.ToShortDateString();

				table.Rows.Add(row);
			}

			this.BuyersListTable.DataSource = table;
			this.BuyersListTable.CellClick += BuyersListTable_CellClick;

			this.BuyersListTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.BuyersListTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.BuyersListTable.Columns["Phone Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.BuyersListTable.Columns["Created Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

			this.BuyersRows.Text = $"Rows: {buyers.Count.ToString("#,###.0")}";
		}

		private void BuyersListTable_CellClick(object? sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				this.BuyerId.Text = this.BuyersListTable.Rows[e.RowIndex].Cells[0].Value.ToString();
				this.BuyerName.Text = this.BuyersListTable.Rows[e.RowIndex].Cells[1].Value.ToString();
				this.Phone.Text = this.BuyersListTable.Rows[e.RowIndex].Cells[2].Value.ToString();
				this.RichAddress.Text = this.BuyersListTable.Rows[e.RowIndex].Cells[3].Value.ToString();

				this.BtnDelete.Enabled = true;
				this.BtnModify.Text = "Update";
			}
		}

		private void BtnModify_Click(object sender, EventArgs e)
		{
			var buyer = new Models.Buyer();
			
			if (string.IsNullOrEmpty(this.BuyerId.Text) || string.IsNullOrWhiteSpace(this.BuyerName.Text))
			{
				return;
			}
			else
			{
				buyer.BuyerName = this.BuyerName.Text;
			}

			if (string.IsNullOrEmpty(this.Phone.Text) || string.IsNullOrWhiteSpace(this.Phone.Text))
			{
				return;
			}
			else
			{
				buyer.Phone = this.Phone.Text;
			}

			if (string.IsNullOrEmpty(this.RichAddress.Text) || string.IsNullOrWhiteSpace(this.RichAddress.Text))
			{
				return;
			}
			else
			{
				buyer.Address = this.RichAddress.Text;
			}
			buyerId = int.Parse(this.BuyerId.Text);
			buyer.BuyerId = buyerId;
			buyer.Updated = DateTime.Now;

			if (this.BtnModify.Text == "Create")
			{
				buyer.Created = DateTime.Now;
				context.Buyers.Add(buyer);
				context.SaveChanges();
			}
			else if (this.BtnModify.Text == "Update")
			{
				var existingBuyer = context.Buyers.FirstOrDefault(b => b.BuyerId == buyerId);
				if (existingBuyer != null)
				{
					var create = existingBuyer.Created;
					context.Entry(existingBuyer).State = EntityState.Detached;
					existingBuyer = buyer;
					existingBuyer.Created = create;
					context.Buyers.Update(existingBuyer);
					context.SaveChanges();
				}
			}

			CancelFields();
			GetAllBuyers(context.Buyers.ToList());
		}

		private void CancelFields()
		{
			this.BuyerId.Text = buyerId.ToString();
			this.BuyerName.Text = string.Empty;
			this.Phone.Text = string.Empty;
			this.RichAddress.Text = string.Empty;

			this.BtnDelete.Enabled = false;
			this.BtnModify.Text = "Create";

			this.BuyersListTable.ClearSelection();
		}

		private void BtnCancel_Click(object sender, EventArgs e) => CancelFields();

		private void SearchField_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.SearchField.Text) || string.IsNullOrWhiteSpace(this.SearchField.Text))
				GetAllBuyers(context.Buyers.ToList());
			else
			{
				var buyers = context.Buyers.Where(b => b.BuyerName.ToLower().StartsWith(this.SearchField.Text.ToLower())).ToList();
				GetAllBuyers(buyers);
			}
		}
	}
}

