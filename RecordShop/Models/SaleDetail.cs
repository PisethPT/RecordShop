using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class SaleDetail
{
    public int SaleDetailId { get; set; }

    public int? SaleId { get; set; }

    public int? VinylId { get; set; }

    public int Quantity { get; set; }

    public double TotalPrice { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Sale? Sale { get; set; }

    public virtual Vinyl? Vinyl { get; set; }
}
