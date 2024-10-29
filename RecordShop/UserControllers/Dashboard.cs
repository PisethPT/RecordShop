using RecordShop.Data;
using RecordShop.Models;
using System.Data;

namespace RecordShop.UserControllers
{
	public partial class Dashboard : UserControl
	{
		private VinylRecordsContext context;
		private List<Vinyl> vinylRecordsNewRelease = new();

		private enum PopularGenreType
		{
			Today,
			Week,
			Month,
			Year
		}

		public Dashboard()
		{
			InitializeComponent();
			context = new VinylRecordsContext();
			GetNewVinylRelease();
			GetPopularBand();
			GetBestSeller();
			GetPopularGenres(PopularGenreType.Today);
			LoadNewDateDashboard();
		}

		private void LoadNewDateDashboard()
		{
			this.TotalVinyl.Text = context.Vinyls.ToList().Count.ToString("F2");
			this.NewReleaseToday.Text = $"{vinylRecordsNewRelease.Count().ToString("F2")} new release on today";

			this.TotalSoldPrice.Text = context.SaleDetails.Where(s => s.Created!.Value.Date.Equals(DateTime.Today)).Select(s => s.TotalPrice).Sum().ToString("C2");
			this.TotalAllSoldPrice.Text = $"{context.SaleDetails.Select(s => s.TotalPrice).Sum().ToString("C2")} all total sold price";

			this.TotalPaidPrice.Text = context.Sales.Where(s => s.Created!.Value.Date.Equals(DateTime.Today)).Select(s => s.Paid).Sum()?.ToString("C2");
			this.TotalAllPaidPrice.Text = $"{context.Sales.Select(s => s.Paid).Sum()?.ToString("C2")} all total paid price";

			this.TotalRemainPrice.Text = context.Sales.Where(s => s.Created!.Value.Date.Equals(DateTime.Today)).Select(s => s.Remain).Sum()?.ToString("C2");
			this.TotalAllRemainPrice.Text = $"{context.Sales.Select(s => s.Remain).Sum()?.ToString("C2")} all total remain price";

			this.TotalSoldVinyl.Text = context.SaleDetails.Where(s => s.Created!.Value.Date.Equals(DateTime.Today)).Select(s => s.VinylId).Count().ToString("F2");
			this.TotalAllVinyl.Text = $"{context.SaleDetails.Select(s => s.VinylId).Count().ToString("F2")} all sold vinyl amount";

		}

		private void GetPopularGenres(PopularGenreType type)
		{

			switch (type)
			{
				case PopularGenreType.Today:
					{
						PopularGenre(this.TodayGenresTable, DateTime.Today.AddDays(-2), DateTime.Today);
						break;
					}
				case PopularGenreType.Week:
					{
						PopularGenre(this.WeekGenresTable, DateTime.Today.AddDays(-7), DateTime.Today);
						break;
					}
				case PopularGenreType.Month:
					{
						PopularGenre(this.MonthGenresTable, DateTime.Today.AddMonths(-1), DateTime.Today);
						break;
					}
				case PopularGenreType.Year:
					{
						PopularGenre(this.YearGenresTable, DateTime.Today.AddMonths(-12), DateTime.Today);
						break;
					}
			}
		}

		private void tabControl_Click(object sender, EventArgs e)
		{
			switch (tabControl.SelectedTab!.Text)
			{
				case "Today": GetPopularGenres(PopularGenreType.Today); break;
				case "Week": GetPopularGenres(PopularGenreType.Week); break;
				case "Month": GetPopularGenres(PopularGenreType.Month); break;
				case "Year": GetPopularGenres(PopularGenreType.Year); break;
			}
		}

		private void PopularGenre(DataGridView gridView, DateTime startDate, DateTime endDate)
		{
			int index = 1;
			var table = GetDataToTable(new List<string>() { "No.", "Genre's Name", "Create Date", "Popularity" });

			var topGenres = context.Vinyls
			.Where(v => v.Created >= startDate && v.Created <= endDate)
			.GroupBy(v => v.Band!.Genre)
			.Select(g => new
			{
				Genre = g.Key,
				Popularity = g.Count()
			})
			.OrderByDescending(g => g.Popularity)
			.Take(10)
			.Select(g => new
			{
				GenreName = g.Genre!.GenreName,
				Created = g.Genre!.Created,
				Popularity = g.Popularity
			})
			.ToList();

			foreach (var genre in topGenres)
			{
				var row = table.NewRow();
				row[0] = index++;
				row[1] = genre!.GenreName;
				row[2] = genre.Created!.Value.ToShortDateString();
				row[3] = genre.Popularity.ToString("#,###.0");
				table.Rows.Add(row);
			}
			gridView.DataSource = table;
			gridView.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			gridView.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			gridView.Columns["Popularity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			gridView.Columns["Popularity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.PopularGenresRows.Text = $"Rows: {topGenres.Count.ToString("#,###.0")}";
		}

		private void GetBestSeller()
		{
			int index = 1;
			var topSeller = context.Sales.GroupBy(g => g.SellerId).Where(s => s.Sum(s => s.Amount) >= 5).Select(s =>
			new
			{
				SellerId = s.Key,
				TotalSaleAmount = s.Sum(s => s.Amount)
			}).OrderByDescending(s => s.TotalSaleAmount).Take(10).ToList();


			var table = GetDataToTable(new List<string>() { "No.", "Seller's Name", "Total_Sale_Amount" });
			foreach (var seller in topSeller)
			{
				var row = table.NewRow();
				row[0] = index++;
				row[1] = context.Sellers.FirstOrDefault(s => s.SellerId == seller.SellerId)!.SellerName;
				row[2] = seller.TotalSaleAmount.ToString("F2");
				table.Rows.Add(row);
			}
			this.BestSellerTable.DataSource = table;

			this.BestSellerTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.BestSellerTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.BestSellerTable.Columns["Total_Sale_Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.BestSellerTable.Columns["Total_Sale_Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.BestSellerRows.Text = $"Rows: {topSeller.Count.ToString("F2")}";
		}

		private void GetPopularBand()
		{
			int index = 1;
			var popularBand = context.Vinyls
			.GroupBy(v => v.BandId)
			.Select(g => new
			{
				BandId = g.Key,
				Favorite = g.Count()
			})
			.OrderByDescending(g => g.Favorite)
			.Join(context.Bands, g => g.BandId, b => b.BandId, 
			(g, b) => new
			{
				b.BandId,
				b.BandName,
				g.Favorite
			}).Take(10)
			.ToList();

			var table = GetDataToTable(new List<string>() { "No.", "Band's Name", "Favorite" });
			foreach (var band in popularBand)
			{
				var row = table.NewRow();
				row[0] = index++;
				row[1] = band.BandName;
				row[2] = band.Favorite!.ToString("#,###.0");
				table.Rows.Add(row);
			}
			this.PopularBandsTable.DataSource = table;

			this.PopularBandsTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.PopularBandsTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.PopularBandsTable.Columns["Favorite"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.PopularBandsTable.Columns["Favorite"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.PopularBandsRows.Text = $"Rows: {popularBand.Count.ToString("#,###.0")}";
		}

		private void GetNewVinylRelease()
		{
			int index = 1;
			var yesterday = DateTime.Today.AddDays(-1).Date;
			var today = DateTime.Today;
			vinylRecordsNewRelease = context.Vinyls.Where(v => v.Created!.Value.Date.Equals(today) || v.Created.Value.Date.Equals(yesterday)).ToList();
			var table = GetDataToTable(new List<string>() { "No.", "Vinyl's Name", "Release Date", "Status", "Sale Price" });
			vinylRecordsNewRelease.Reverse();
			foreach (var vinyl in vinylRecordsNewRelease)
			{
				var row = table.NewRow();
				row[0] = index++;
				row[1] = vinyl.VinylName;
				row[2] = vinyl.Created!.Value.ToString("d");
				if (vinyl.Created.Value.Date.Equals(yesterday))
					row[3] = "Yesterday";
				else
					row[3] = "New";
				row[4] = vinyl.SalePrice.ToString("C2");
				table.Rows.Add(row);
			}

			this.NewVinylTable.DataSource = table;
			this.NewVinylTable.Columns["No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.NewVinylTable.Columns["No."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.NewVinylTable.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

	}
}
