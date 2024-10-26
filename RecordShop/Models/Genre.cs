using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class Genre
{
    public int GenreId { get; set; }

    public string GenreName { get; set; } = null!;

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ICollection<Band> Bands { get; set; } = new List<Band>();
}
