using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _09_DbFirstYaklasimi.Models;

[Index("CategoryName", Name = "CategoryName")]
public partial class Category
{
    [Key]
    [Column("CategoryID")]
    [DisplayName("Kategori No")]
    public int CategoryId { get; set; }

    [StringLength(15)]
    [DisplayName("Kategori Adı")]
    [Required(ErrorMessage ="Zorunlu Alan")]
    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    [DisplayName("Kategori Tanımı")]
    public string? Description { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    [DisplayName("Kategori Resim Url")]
    public string? ImageUrl { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
