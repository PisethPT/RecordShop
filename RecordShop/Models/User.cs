using System;
using System.Collections.Generic;

namespace RecordShop.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte? Status { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }
}
