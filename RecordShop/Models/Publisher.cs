using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }

    public virtual ICollection<Vinyl> Vinyls { get; set; } = new List<Vinyl>();
}
