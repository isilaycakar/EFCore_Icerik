using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Table("PersonalTrigger")]
public partial class PersonalTrigger
{
    [Key]
    public int PersonelId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TotalOrderAmount { get; set; }
}
