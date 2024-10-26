using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class Seller
{
    public int SellerId { get; set; }

    public string SellerName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
