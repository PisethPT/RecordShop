using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class Sale
{
    public int SaleId { get; set; }

    public int? SellerId { get; set; }

    public int? BuyerId { get; set; }

    public double Amount { get; set; }

    public double? Paid { get; set; }

    public double? Remain { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Buyer? Buyer { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();

    public virtual Seller? Seller { get; set; }
}
