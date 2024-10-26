using RecordShop.Data;
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
		public Dashboard()
		{
			InitializeComponent();
			context = new VinylRecordsContext();
			GetNewVinylRelease();
			GetPopularBand();
			GetBestSeller();
			GetPopularGenres();
		}

		private void GetPopularGenres()
		{
			int index = 1;
			var genres = context.Genres.ToList();
			var table = GetDataToTable<Models.Genre>(genres, new List<string>() { "No.", "Genre's Name", "Create Date", "Favorite" });
			foreach(var genre in genres)
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
			this.PopularGenresRows.Text= $"Rows: {genres.Count.ToString("#,###.0")}";
		}

		private void GetBestSeller()
		{
			//throw new NotImplementedException();
		}

		private void GetPopularBand()
		{
			//throw new NotImplementedException();
		}

		private void GetNewVinylRelease()
		{
			int index = 1;
			var vinylRecords = context.Vinyls.Where(v => v.Created!.Value.Date.Equals(DateTime.Today)).ToList();
			var table = GetDataToTable<Models.Vinyl>( vinylRecords, new List<string>() { "No.", "Vinyl's Name", "Release Date", "Status", "Sale Price"});
			foreach (var vinyl in vinylRecords) 
			{ 
				var row = table.NewRow();
				row[0] = index++;
				row[1] = vinyl.VinylName;
				row[2] = vinyl.Created!.Value.ToShortDateString();
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
			this.NewVinylRows.Text = $"Rows: {vinylRecords.Count.ToString("#,###.0")}";
		}

		private DataTable GetDataToTable<T>(List<T> t, List<string> columnsHeadText)
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
