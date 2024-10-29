using RecordShop.Data;
using RecordShop.Models;
using System.Data;
using static RecordShop.Statics.StaticComponents;

namespace RecordShop.UserControllers
{
	public partial class Order : UserControl
	{
		private VinylRecordsContext context;
		private int invoiceId = 0;
		private int saleDetailId = 0;
		char[] trimChars = new char[] { '(', ')', '$' };
		public decimal previousPaidValue = 1;
		public decimal previousRemainValue = 1;
		public int MyProperty { get; set; }
		private string bandName = string.Empty;
		public Order()
		{
			InitializeComponent();

			try
			{
				if (this is not null)
				{
					RecordShop.Statics.StaticComponents.FlowOrderContainer = this.FlowOrderContainer;
					RecordShop.Statics.StaticComponents.Subtotal = this.Subtotal;
					RecordShop.Statics.StaticComponents.PayableAmount = this.PayableAmount;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			context = new VinylRecordsContext();
			GetSellers();
			GetBuyers();
			GetVinyl(context.Vinyls.ToList());
			GetBands();
			GetAllBandDefault();
			invoiceId = int.Parse((context.Sales.Count() + 1).ToString());
			this.InvoiceId.Text = invoiceId.ToString();
			saleDetailId = int.Parse((context.SaleDetails.Count() + 1).ToString());
		}

		private void GetVinyl(List<Vinyl> vinylRecords)
		{
			this.FlowVinylContainer.Controls.Clear();
			foreach (Vinyl vinyl in vinylRecords)
			{
				var vinylCard = new VinylCard();
				vinylCard.BandName.Text = $"Band: {context.Bands.FirstOrDefault(b => b.BandId == vinyl.BandId)!.BandName}";
				vinylCard.GenreName.Text = $"Genre: {context.Genres.FirstOrDefault(g => g.GenreId == vinyl.Band!.GenreId)!.GenreName}";
				vinylCard.Publisher.Text = $"Publisher: {context.Publishers.FirstOrDefault(p => p.PublisherId == vinyl.PublisherId)!.Name}";
				vinylCard.VinylName.Text = $"{vinyl.VinylName}";

				var status = context.VinylForDiscounts.Where(v => v.VinylId == vinyl.VinylId).FirstOrDefault();
				if (status != null)
				{
					vinylCard.SalePrice.Text = status.SellingPrice.ToString("$#,###.00");
					vinylCard.OldPrice.Text = vinyl.SalePrice.ToString("$#,###.00");
				}
				else
					vinylCard.SalePrice.Text = vinyl.SalePrice.ToString("$#,###.00");

				this.FlowVinylContainer.Controls.Add(vinylCard);
			}

			this.AllVinylRows.Text = $"Rows: {vinylRecords.Count.ToString("#,###.0")}";
		}

		private void GetBands()
		{
			this.FlowBandContainer.Controls.Clear();
			this.FlowBandContainer.Controls.Add(BandButton("All"));
			foreach (var band in context.Bands)
			{
				var bandButton = BandButton(band.BandName);
				this.FlowBandContainer.Controls.Add(bandButton);
			}

		}

		private void GetSellers()
		{
			foreach (var seller in context.Sellers)
			{
				this.CbSellerName.Items.Add(seller.SellerName);
			}

			this.CbSellerName.SelectedIndex = 0;
		}

		private void GetBuyers()
		{
			foreach (var buyer in context.Buyers)
			{
				this.CbBuyerName.Items.Add(buyer.BuyerName);
			}

			this.CbBuyerName.SelectedIndex = 0;
		}

		private Button BandButton(string bandName)
		{
			var band = new Button();
			band.FlatAppearance.BorderSize = 0;
			band.FlatStyle = FlatStyle.Flat;
			band.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			band.Location = new Point(3, 3);
			band.Name = $"{bandName.Replace(' ', '_')}";
			band.Size = new Size(160, 36);
			band.TabIndex = 0;
			band.Text = bandName;
			band.UseVisualStyleBackColor = true;
			band.Click += (s, e) =>
			{
				// MessageBox.Show(band.Name.ToString());
				this.SearchField.Text = string.Empty;
				foreach (Button button in this.FlowBandContainer.Controls)
				{
					if (button.Text == bandName && bandName != "All")
					{
						SearchVinylByBand(bandName);
						button.Enabled = false;
						button.BackColor = SystemColors.ControlLight;
					}else if(button.Text == "All" && bandName == "All")
					{
						GetVinyl(context.Vinyls.ToList());
						button.Enabled = false;
						button.BackColor = SystemColors.ControlLight;
					}
					else
					{
						button.Enabled = true;
						button.BackColor = SystemColors.Window;
					}
				}
			};
			return band;
		}

		private void SearchVinylByBand(string bandName)
		{
			var bandId = context.Bands.FirstOrDefault(b => b.BandName == bandName)!.BandId;
			var vinyl = context.Vinyls.Where(v => v.BandId == bandId).ToList();
			GetVinyl(vinyl);
		}

		private void BtnSubmit_Click(object sender, EventArgs e)
		{
			if (FlowOrderContainer.Controls.Count > 0)
			{
				InsertOrder();
				ResetFields();
				RecordShop.Statics.StaticComponents.orderNotificationCount.Text = (RecordShop.Statics.StaticComponents.NewOrderArchiveInt++).ToString();
			}
			else
				MessageBox.Show("Please Add Vinyl for Order.", "Order Warning");
		}

		private void InsertOrder()
		{
			if (FlowOrderContainer.Controls.Count > 0)
			{
				try
				{
					int invoiceId = int.Parse(this.InvoiceId.Text);
					string sellerName = this.CbSellerName.Text;
					string buyerName = CbBuyerName.Text;
					int amount = int.Parse(this.Subtotal.Text.Replace(".00", ""));
					float paid = float.Parse(this.Paid.Value.ToString().Trim('$'));
					float remain = float.Parse(this.Remain.Value.ToString().Trim('$'));

					int saleId = context.ProInsertOrder(invoiceId, sellerName, buyerName, amount, paid, remain);

					foreach (OrderCard card in FlowOrderContainer.Controls)
					{
						int vinylId = context.Vinyls.FirstOrDefault(v => v.VinylName == card.VinylName.Text)!.VinylId;
						int quantity = (int)card.Quantity.Value;
						double totalPrice = double.Parse(card.SalePrice.Text.Trim('$')) * quantity;
						var saleDetail = InsertOrderVinyl(saleId, vinylId, quantity, totalPrice);
						context.SaleDetails.Add(saleDetail);
						context.SaveChanges();
					}

					invoiceId++;
					this.InvoiceId.Text = invoiceId.ToString();
				}
				catch (Exception ex)
				{

				}
			}
		}

		private SaleDetail InsertOrderVinyl(int saleId, int vinylId, int quantity, double totalPrice)
		{
			SaleDetail saleDetail = new SaleDetail();
			saleDetail.SaleDetailId = saleDetailId;
			saleDetail.SaleId = saleId;
			saleDetail.VinylId = vinylId;
			saleDetail.Quantity = quantity;
			saleDetail.TotalPrice = totalPrice;
			saleDetail.Created = DateTime.Now;
			saleDetail.Updated = DateTime.Now;
			saleDetailId++;

			return saleDetail;
		}

		private void Paid_ValueChanged(object sender, EventArgs e)
		{
			decimal payableAmount = decimal.Parse(this.PayableAmount.Text.Trim(trimChars));
			var tempValue = this.Paid.Value - previousPaidValue;
			try
			{
				if (tempValue == 1)
				{
					if (this.Paid.Value >= payableAmount)
					{
						this.Paid.Value = payableAmount;
						this.Remain.Value = 0;
					}
					else if (this.Paid.Value < payableAmount)
					{
						this.Remain.Value--;
					}
				}
				else if (tempValue == -1 && tempValue < 0)
				{
					if (this.Paid.Value > 0)
					{
						this.Remain.Value++;
					}
					else if (this.Paid.Value <= 0)
					{
						this.Remain.Value = payableAmount;
					}
				}
				else
				{
					if (this.Paid.Value >= payableAmount)
					{
						this.Paid.Value = payableAmount;
						this.Remain.Value = 0;
					}
					else if (this.Paid.Value < payableAmount)
					{
						this.Remain.Value -= tempValue;
					}
				}

				previousPaidValue = this.Paid.Value;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Remain_ValueChanged(object sender, EventArgs e)
		{
			//decimal payableAmount = decimal.Parse(this.PayableAmount.Text.Trim(trimChars));
			//var tempValue = this.Remain.Value - previousRemainValue;
			//try
			//{
			//	if (tempValue == 1)
			//	{
			//		if (this.Remain.Value >= payableAmount)
			//		{
			//			this.Remain.Value = payableAmount;
			//			this.Paid.Value = 0;
			//		}
			//		else if (this.Remain.Value < payableAmount)
			//		{
			//			this.Paid.Value--;
			//		}
			//	}
			//	else if (tempValue == -1 && tempValue < 0)
			//	{
			//		if (this.Remain.Value > 0)
			//		{
			//			this.Paid.Value++;
			//		}
			//		else if (this.Remain.Value <= 0)
			//		{
			//			this.Paid.Value = payableAmount;
			//		}
			//	}
			//	else
			//	{
			//		if (this.Remain.Value >= payableAmount)
			//		{
			//			this.Remain.Value = payableAmount;
			//			this.Paid.Value = 0;
			//		}
			//		else if (this.Remain.Value < payableAmount)
			//		{
			//			this.Paid.Value -= tempValue;
			//		}
			//	}

			//	previousRemainValue = this.Remain.Value;
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}
		}

		private void PayableAmount_TextChanged(object sender, EventArgs e)
		{
			this.Paid.Value = decimal.Parse(this.PayableAmount.Text.Trim(trimChars));
		}

		private void BtnCancel_Click(object sender, EventArgs e) => ResetFields();

		private void ResetFields()
		{
			this.CbSellerName.SelectedIndex = 0;
			this.CbBuyerName.SelectedIndex = 0;
			this.DiscountPrice.Text = "$0.0";
			this.Paid.Value = 0;
			this.Remain.Value = 0;
			RecordShop.Statics.StaticComponents.Subtotal.Text = "0.0";
			RecordShop.Statics.StaticComponents.PayableAmount.Text = "$0.0";
			RecordShop.Statics.StaticComponents.PayableAmountDouble = 0d;
			RecordShop.Statics.StaticComponents.SubtotalInt = 0;
			RecordShop.Statics.StaticComponents.FlowOrderContainer.Controls.Clear();
		}

		private void SearchField_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.SearchField.Text) || string.IsNullOrWhiteSpace(this.SearchField.Text))
				GetVinyl(context.Vinyls.ToList());
			else
			{
				var vinyl = context.Vinyls.Where(v => v.VinylName.ToLower().StartsWith(this.SearchField.Text.ToLower())).ToList();
				GetVinyl(vinyl);
				//var button = this.FlowBandContainer.Controls[0] as Button;
				GetAllBandDefault();
			}
		}

		private void GetAllBandDefault()
		{
			foreach (Button button in this.FlowBandContainer.Controls)
			{
				if (button.Text == "All")
				{
					button.Enabled = false;
					button.BackColor = SystemColors.ControlLight;
				}
				else
				{
					button.Enabled = true;
					button.BackColor = SystemColors.Window;
				}
			}
		}
	}
}
