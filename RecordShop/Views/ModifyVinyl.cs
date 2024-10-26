using RecordShop.Data;
using RecordShop.Models;

namespace RecordShop.Views
{
	public partial class ModifyVinyl : Form
	{
		private VinylRecordsContext context;
		private int vinylId;
		public ModifyVinyl()
		{
			InitializeComponent();
			context = new VinylRecordsContext();
			vinylId = context.Vinyls.OrderByDescending(v => v.VinylId).FirstOrDefault()!.VinylId + 1;
			this.VinylId.Text = vinylId.ToString();
			foreach (var band in context.Bands)
			{
				this.CbChooseBand.Items.Add(band.BandName);
			}

			foreach (var publisher in context.Publishers)
			{
				this.CbChoosePublisher.Items.Add(publisher.Name);
			}

			this.CbChoosePublisher.SelectedIndex = 0;
			this.CbChooseBand.SelectedIndex = 0;

			this.VinylId.Text = vinylId.ToString();
		}

		private void BtnModify_Click(object sender, EventArgs e) => VinylDetail();

		private void VinylDetail()
		{
			var vinyl = new Vinyl();
			if (string.IsNullOrEmpty(this.VinylName.Text) || string.IsNullOrWhiteSpace(this.VinylName.Text))
			{
				return;
			}
			else
			{
				vinyl.VinylName = this.VinylName.Text;
			}

			if (this.NumberOfTrack.Value <= 0)
			{
				return;
			}
			else
			{
				vinyl.NumberOfTrack = (int)this.NumberOfTrack.Value;
			}

			if (this.PrimeCost.Value <= 0)
			{
				return;
			}
			else
			{
				vinyl.PrimeCost = (double)this.PrimeCost.Value;
			}

			if (this.SalePrice.Value <= 0)
			{
				return;
			}
			else
			{
				vinyl.SalePrice = (double)this.SalePrice.Value;
			}

			vinyl.VinylId = int.Parse(this.VinylId.Text);
			vinyl.BandId = this.CbChooseBand.SelectedIndex + 1;
			vinyl.PublisherId = this.CbChoosePublisher.SelectedIndex + 1;
			vinyl.DateOfPublishing = this.DateOfPublishing.Value;
			vinyl.Created = DateTime.Now;
			vinyl.Updated = DateTime.Now;
			vinyl.Status = 1;

			if (this.BtnModify.Text.Equals("Create"))
			{
				context.Vinyls.Add(vinyl);
				context.SaveChanges();
			}
			else if (this.BtnModify.Text.Equals("Update"))
			{

			}
			ClearFields();

		}

		private void ClearFields()
		{
			this.VinylName.Text = string.Empty;
			this.CbChooseBand.SelectedIndex = 0;
			this.CbChoosePublisher.SelectedIndex = 0;
			this.NumberOfTrack.Value = 0;
			this.DateOfPublishing.Value = DateTime.Now;
			this.PrimeCost.Value = 0;
			this.SalePrice.Value = 0;
		}

		private void BtnReset_Click(object sender, EventArgs e) => ClearFields();
	}
}
