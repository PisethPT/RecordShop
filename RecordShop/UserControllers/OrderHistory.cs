using RecordShop.Data;
using RecordShop.Models;
using RecordShop.Views;
using System.Data;

namespace RecordShop.UserControllers
{
	public partial class OrderHistory : UserControl
	{
		private readonly VinylRecordsContext context;
		string iconDirectoryPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "Images");

		public OrderHistory()
		{
			InitializeComponent();
			context = new VinylRecordsContext();
			GetOrderHistory(context.Sales.ToList());
		}

		private void GetOrderHistory(List<Sale> sales)
		{
			DataTable table = new DataTable();
			table.Columns.Add("Invoice No.");
			table.Columns.Add("Seller Name");
			table.Columns.Add("Buyer Name");
			table.Columns.Add("Amount");
			table.Columns.Add("Paid");
			table.Columns.Add("Remain");
			table.Columns.Add("Total Payable");
			table.Columns.Add("Order Data");

			foreach (var sale in sales)
			{
				var row = table.NewRow();
				row[0] = sale.SaleId;
				row[1] = context.Sellers.FirstOrDefault(s => s.SellerId == sale.SaleId)!.SellerName;
				row[2] = context.Buyers.FirstOrDefault(b => b.BuyerId == sale.BuyerId)!.BuyerName;
				row[3] = sale.Amount.ToString("#,###.0");
				row[4] = sale.Paid?.ToString("C2");
				row[5] = sale.Remain?.ToString("C2");
				row[6] = (sale.Paid + sale.Remain)?.ToString("C2");
				row[7] = sale.Created?.ToShortDateString();

				table.Rows.Add(row);
			}
			this.OrderHistoryListTable.DataSource = table;

			try
			{
				if (!this.OrderHistoryListTable.Columns[0].HeaderText.Equals("Order Detail"))
				{
					DataGridViewImageColumn detail = new DataGridViewImageColumn();
					detail.HeaderText = "Order Detail";
					detail.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
					detail.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "icons8-table-24.png")), new Size(20, 20));
					this.OrderHistoryListTable.Columns.Add(detail);

					this.OrderHistoryListTable.CellClick += OrderHistoryListTable_CellClick;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void OrderHistoryListTable_CellClick(object? sender, DataGridViewCellEventArgs e)
		{
			if (this.OrderHistoryListTable.Columns[e.ColumnIndex].HeaderText.Equals("Order Detail") && e.RowIndex >= 0)
			{
				string name = this.OrderHistoryListTable.Rows[e.RowIndex].Cells[3].Value.ToString()!;
				int buyerId = context.Buyers.FirstOrDefault(b => b.BuyerName.Equals(name))!.BuyerId;

				BuyerOrderDetail orderDetail = new BuyerOrderDetail(buyerId, OrderDetail(e.RowIndex));
				orderDetail.ShowDialog();
			}
		}


		private OrderHeadInfo OrderDetail(int rowIndex)
		{
			OrderHeadInfo orderHeadInfo = new OrderHeadInfo();
			orderHeadInfo.BuyerName = this.OrderHistoryListTable.Rows[rowIndex].Cells[3].Value.ToString()!;
			orderHeadInfo.Subtotal = int.Parse(this.OrderHistoryListTable.Rows[rowIndex].Cells[4].Value.ToString()!.Replace(".0",""));
			orderHeadInfo.Remain = double.Parse(this.OrderHistoryListTable.Rows[rowIndex].Cells[6].Value.ToString()!.Trim('$')!);
			orderHeadInfo.TotalPayable = double.Parse(this.OrderHistoryListTable.Rows[rowIndex].Cells[7].Value.ToString()!.Trim('$'));
			orderHeadInfo.OrderDate = DateOnly.Parse(this.OrderHistoryListTable.Rows[rowIndex].Cells[8].Value.ToString()!);

			return orderHeadInfo;
		}
	}
}
