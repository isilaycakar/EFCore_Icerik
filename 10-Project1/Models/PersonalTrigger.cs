using System;
using System.Collections.Generic;

namespace _10_Project1.Models;

public partial class PersonalTrigger
{
    public int PersonelId { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public decimal? TotalOrderAmount { get; set; }
}
