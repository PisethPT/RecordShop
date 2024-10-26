using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class VinylForDiscount
{
    public int Id { get; set; }

    public int? VinylId { get; set; }

    public DateTime DiscountDate { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public double SellingPrice { get; set; }

    public virtual Vinyl? Vinyl { get; set; }
}
