using static RecordShop.Statics.StaticComponents;
namespace RecordShop.UserControllers
{
	public partial class VinylCard : UserControl
	{
		public VinylCard()
		{
			InitializeComponent();
		}

		private void BtnVinylCard_Click(object sender, EventArgs e)
		{
			bool IsInvalid = false;
			OrderCard orderCard = new OrderCard();
			OrderCardDetail(orderCard);


			if (FlowOrderContainer.Controls.Count > 0)
			{
				foreach (OrderCard card in FlowOrderContainer.Controls)
				{
					if (string.Compare(card.VinylName.Text, orderCard.VinylName.Text) == 0)
					{
						var quantity = card.Quantity.Value;
						quantity++;
						card.Quantity.Value = quantity;
						IsInvalid = true;
						break;
					}
					else
						IsInvalid = false;
				}

				if (!IsInvalid)
				{
					FlowOrderContainer.Controls.Add(orderCard);
					SubtotalInt++;
					Subtotal.Text = SubtotalInt.ToString("C2").Trim('$');
					PayableAmountDouble += double.Parse(orderCard.SalePrice.Text.ToString().Trim('$'));
					PayableAmount.Text = PayableAmountDouble.ToString("C2");
				}
			}
			else
			{
				FlowOrderContainer.Controls.Add(orderCard);
				SubtotalInt++;
				Subtotal.Text = SubtotalInt.ToString("C2").Trim('$');
				PayableAmountDouble += double.Parse(orderCard.SalePrice.Text.ToString().Trim('$'));
				PayableAmount.Text = PayableAmountDouble.ToString("C2");
			}
		}

		private void OrderCardDetail(OrderCard card)
		{
			card.VinylName.Text = this.VinylName.Text;
			card.SalePrice.Text = this.SalePrice.Text;
		}
	}
}
