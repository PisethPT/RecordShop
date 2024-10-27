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

namespace RecordShop.UserControllers
{
	public partial class Dashboard : UserControl
	{
		private VinylRecordsContext context;
		private List<Vinyl> vinylRecordsNewRelease = new();
		public Dashboard()
		{
			InitializeComponent();
			context = new VinylRecordsContext();
			GetNewVinylRelease();
			GetPopularBand();
			GetBestSeller();
			GetPopularGenres();
			LoadNewDateDashboard();
		}

		private void LoadNewDateDashboard()
		{
			this.TotalVinyl.Text = context.Vinyls.ToList().Count.ToString("#,###.0");
			this.NewReleaseToday.Text = $"{vinylRecordsNewRelease.Count().ToString("#,###.0")} new release on today";
		}

		private void GetPopularGenres()
		{
			int index = 1;
			var genres = context.Genres.ToList();
			var table = GetDataToTable(new List<string>() { "No.", "Genre's Name", "Create Date", "Favorite" });
			foreach (var genre in genres)
			{
				var row = table.NewRow();
				row[0] = index++;
				row[1] = genre.GenreName;
				row[2] = genre.Created!.Value.ToShortDateString();
				row[3] = "0";
				table.Rows.Add(row);
			}
			this.PopularGenresTable.DataSource = table;
			this.PopularGenresTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.PopularGenresTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.PopularGenresRows.Text = $"Rows: {genres.Count.ToString("#,###.0")}";
		}

		private void GetBestSeller()
		{
			int index = 1;
			var top10Seller = context.Sales.GroupBy(g => g.SellerId).Where(s => s.Sum(s => s.Amount) >= 5).Select(s =>
			new
			{
				SellerId = s.Key,
				TotalSaleAmount = s.Sum(s => s.Amount)
			}).OrderByDescending(s => s.TotalSaleAmount).Take(10).ToList();


			var table = GetDataToTable(new List<string>() { "No.", "Seller's Name", "Total_Sale_Amount" });
			foreach (var seller in top10Seller)
			{
				var row = table.NewRow();
				row[0] = index++;
				row[1] = context.Sellers.FirstOrDefault(s => s.SellerId == seller.SellerId)!.SellerName;
				row[2] = seller.TotalSaleAmount.ToString("#,###.0");
				table.Rows.Add(row);
			}
			this.BestSellerTable.DataSource = table;

			this.BestSellerTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.BestSellerTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.BestSellerTable.Columns["Total_Sale_Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.BestSellerTable.Columns["Total_Sale_Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		private void GetPopularBand()
		{
			//throw new NotImplementedException();
		}

		private void GetNewVinylRelease()
		{
			int index = 1;
			var yesterday = DateTime.Today.AddDays(-1).Date;
			// var y = context.Vinyls.Where(v => v.Created!.Value.Day.Equals(yesterday)).FirstOrDefault();
			var today = DateTime.Today;
			vinylRecordsNewRelease = context.Vinyls.Where(v => v.Created!.Value.Date.Equals(today) || v.Created.Value.Date.Equals(yesterday)).ToList();
			var table = GetDataToTable(new List<string>() { "No.", "Vinyl's Name", "Release Date", "Status", "Sale Price" });
			foreach (var vinyl in vinylRecordsNewRelease)
			{
				var row = table.NewRow();
				row[0] = index++;
				row[1] = vinyl.VinylName;
				row[2] = vinyl.Created!.Value.ToString("d");
				row[3] = "New";
				row[4] = vinyl.SalePrice.ToString("C2");
				table.Rows.Add(row);
			}

			this.NewVinylTable.DataSource = table;
			this.NewVinylTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.NewVinylTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.NewVinylTable.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.NewVinylTable.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.NewVinylTable.Columns["Status"].DefaultCellStyle.ForeColor = Color.Blue;
			this.NewVinylTable.Columns["Status"].DefaultCellStyle.SelectionForeColor = Color.Blue;
			this.NewVinylTable.Columns["Release Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.NewVinylTable.Columns["Sale Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.NewVinylRows.Text = $"Rows: {vinylRecordsNewRelease.Count.ToString("#,###.0")}";
		}

		private DataTable GetDataToTable(List<string> columnsHeadText)
		{
			DataTable data = new DataTable();

			foreach (var column in columnsHeadText)
			{
				data.Columns.Add(column);
			}

			return data;
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}
	}
}
