using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class Vinyl
{
    public int VinylId { get; set; }

    public string VinylName { get; set; } = null!;

    public int? BandId { get; set; }

    public int? PublisherId { get; set; }

    public int NumberOfTrack { get; set; }

    public DateTime? DateOfPublishing { get; set; }

    public double PrimeCost { get; set; }

    public double SalePrice { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public byte Status { get; set; }

    public virtual Band? Band { get; set; }

    public virtual Publisher? Publisher { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();

    public virtual ICollection<VinylForDiscount> VinylForDiscounts { get; set; } = new List<VinylForDiscount>();
}
