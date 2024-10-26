using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class Buyer
{
    public int BuyerId { get; set; }

    public string BuyerName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
