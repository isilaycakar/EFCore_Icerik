using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Keyless]
[Table("deletedEmployees")]
public partial class DeletedEmployee
{
    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [StringLength(10)]
    public string? FirstName { get; set; }

    [Column("LastNAme")]
    [StringLength(10)]
    public string? LastName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DeleteDate { get; set; }
}
