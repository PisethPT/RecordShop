using static RecordShop.Statics.StaticComponents;
namespace RecordShop.UserControllers
{
	public partial class OrderCard : UserControl
	{
		public decimal previousValue = 1;
		public OrderCard()
		{
			InitializeComponent();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			if (FlowOrderContainer.Controls.Count > 0)
			{
				try
				{
					foreach (OrderCard card in FlowOrderContainer.Controls)
					{
						if (string.Compare(card.VinylName.Text, this.VinylName.Text) == 0)
						{
							var quantity = int.Parse(this.Quantity.Value.ToString());
							SubtotalInt -= quantity;
							Subtotal.Text = SubtotalInt.ToString("C2").Trim('$');
							double totalPrice = double.Parse(this.SalePrice.Text.ToString().Trim('$')) * quantity;
							PayableAmountDouble -= totalPrice;
							PayableAmount.Text = PayableAmountDouble.ToString("C2");

							FlowOrderContainer.Controls.Remove(card);
						}
					}
				}
				catch (Exception ex) 
				{ 
				}
			}
		}

		private void Quantity_ValueChanged(object sender, EventArgs e)
		{
			var tempValue = this.Quantity.Value - previousValue;
			if (tempValue == 1 || tempValue == -1)
			{
				if (previousValue < this.Quantity.Value)
				{
					SubtotalInt++;
					Subtotal.Text = SubtotalInt.ToString("C2").Trim('$');
					PayableAmountDouble += double.Parse(this.SalePrice.Text.ToString().Trim('$'));
					PayableAmount.Text = PayableAmountDouble.ToString("C2");
				}
				else if (previousValue > this.Quantity.Value)
				{
					SubtotalInt--;
					Subtotal.Text = SubtotalInt.ToString("C2").Trim('$');
					PayableAmountDouble -= double.Parse(this.SalePrice.Text.ToString().Trim('$'));
					PayableAmount.Text = PayableAmountDouble.ToString("C2");
				}
			}
			else
			{
				if (previousValue < this.Quantity.Value)
				{
					SubtotalInt += (int)tempValue;
					Subtotal.Text = SubtotalInt.ToString("C2").Trim('$');

					PayableAmountDouble += double.Parse(this.SalePrice.Text.ToString().Trim('$')) * (double)tempValue;
					PayableAmount.Text = PayableAmountDouble.ToString("C2");
				}
				else if (previousValue > this.Quantity.Value)
				{
					SubtotalInt += (int)tempValue;
					Subtotal.Text = SubtotalInt.ToString("C2").Trim('$');
					PayableAmountDouble += double.Parse(this.SalePrice.Text.ToString().Trim('$')) * (double)tempValue; ;
					PayableAmount.Text = PayableAmountDouble.ToString("C2");
				}
			}

			
			previousValue = this.Quantity.Value;
		}

		private void Quantity_Click(object sender, EventArgs e)
		{
			previousValue = this.Quantity.Value;
		}
	}
}
