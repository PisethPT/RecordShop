namespace RecordShop.Statics
{
	public static class StaticComponents
	{
		public static FlowLayoutPanel FlowOrderContainer { get; set; } = null!;
		public static Label Subtotal { get; set; } = null!;
		public static Label DiscountPrice { get; set; } = null!;
		public static Label PayableAmount { get; set; } = null!;
		public static TextBox SearchField { get; set; } = null!;
		public static Button orderNotificationCount { get; set; } = null!;
		public static int SubtotalInt { get; set; } = 0;
		public static double DiscountDouble { get; set; } = 0d;
		public static double PayableAmountDouble { get; set; } = 0d;
		public static int NewOrderArchiveInt { get; set; } = 1;
	}
}
