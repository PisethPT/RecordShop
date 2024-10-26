using RecordShop.Data;
using RecordShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordShop.Views
{
	public partial class BuyerOrderDetail : Form
	{
		private readonly VinylRecordsContext context;
		public BuyerOrderDetail(int buyerId, OrderHeadInfo orderHeadInfo)
		{
			InitializeComponent();
			context = new VinylRecordsContext();
			GetOrderDetailByBuyerId(buyerId, orderHeadInfo);
		}

		private void GetOrderDetailByBuyerId(int buyerId, OrderHeadInfo orderHeadInfo)
		{
			int index = 1;
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("No.");
			dataTable.Columns.Add("Vinyl's Name");
			dataTable.Columns.Add("Quantity");
			dataTable.Columns.Add("Total Price");

			foreach (var item in context.GetOrderDetailByBuyersId(buyerId).ToList())
			{
				var row = dataTable.NewRow();
				row[0] = index++;
				row[1] = item.VinylName;
				row[2] = item.Quantity.ToString("#,###.0");
				row[3] = item.TotalPrice.ToString("C2");
				dataTable.Rows.Add(row);
			}

			this.OrderHistoryListTable.DataSource = dataTable;
			this.BuyersRows.Text = $"Rows: {dataTable.Rows.Count.ToString("#,###.0")}";
			this.OrderHistoryListTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.OrderHistoryListTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.OrderHistoryListTable.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.OrderHistoryListTable.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.OrderHistoryListTable.Columns["Total Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.OrderHistoryListTable.Columns["Total Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

			this.BuyerName.Text = orderHeadInfo.BuyerName;
			this.Subtotal.Text += orderHeadInfo.Subtotal.ToString("#,###.0");
			this.Payable.Text += orderHeadInfo.TotalPayable.ToString("C2");
			this.Remain.Text += orderHeadInfo.Remain.ToString("C2");
			this.OrderDate.Text += orderHeadInfo.OrderDate.ToShortDateString();

		}

	}
}
