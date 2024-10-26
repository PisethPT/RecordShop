namespace RecordShop.Models
{
	public class OrderDetailByBuyerId
	{
		public int BuyerId { get; set; }
		public string BuyerName { get; set; }
		public string VinylName { get; set; }
		public int Quantity { get; set; }
		public double TotalPrice { get; set; }
		public double Paid { get; set; }
		public double Remain { get; set; }
		public DateTime Created { get; set; }
	}

	public struct OrderHeadInfo
	{
		public string BuyerName { get; set; }
		public DateOnly OrderDate { get; set; }
		public int Subtotal { get; set; }
		public double TotalPayable { get; set; }
		public double Remain { get; set; }
	}
}
