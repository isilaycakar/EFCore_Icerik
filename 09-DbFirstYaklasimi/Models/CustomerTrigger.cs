using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Keyless]
[Table("customerTrigger")]
public partial class CustomerTrigger
{
    [Column("CustomerID")]
    [StringLength(5)]
    public string CustomerId { get; set; } = null!;

    [StringLength(40)]
    public string CompanyName { get; set; } = null!;

    [StringLength(15)]
    public string? City { get; set; }

    [StringLength(15)]
    public string? Country { get; set; }

    [StringLength(24)]
    public string? Phone { get; set; }

    [StringLength(15)]
    public string? State { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateTime { get; set; }
}
