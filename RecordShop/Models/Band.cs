using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class Band
{
    public int BandId { get; set; }

    public string BandName { get; set; } = null!;

    public int? GenreId { get; set; }

    public string Origin { get; set; } = null!;

    public int NumberOfAlbums { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual Genre? Genre { get; set; }

    public virtual ICollection<Vinyl> Vinyls { get; set; } = new List<Vinyl>();
}
