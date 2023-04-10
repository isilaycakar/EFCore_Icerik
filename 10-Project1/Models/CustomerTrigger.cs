using System;
using System.Collections.Generic;

namespace _10_Project1.Models;

public partial class CustomerTrigger
{
    public string CustomerId { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? State { get; set; }

    public DateTime? DateTime { get; set; }
}
