using System;
using System.Collections.Generic;

namespace _10_Project1.Models;

public partial class DeletedEmployee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime DeleteDate { get; set; }
}
