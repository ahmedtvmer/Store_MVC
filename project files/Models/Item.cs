using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string Title { get; set; } = null!;

    public int Price { get; set; }
    [Display(Name = "Release Date")]
    public DateOnly ReleaseDate { get; set; }
    [Display(Name = "Category ID")]
    public int? CategoryId { get; set; }
    [Display(Name = "Order ID")]
    public int? OrderId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Order? Order { get; set; }
}
