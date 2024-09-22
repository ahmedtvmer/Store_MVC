using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public partial class Category
{
    public int CategoryId { get; set; }
    [Display(Name = "Category Name")]
    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
