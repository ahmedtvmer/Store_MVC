using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public partial class Order
{
    public int OrderId { get; set; }
    [Display(Name = "Status")]
    public int OrderStatus { get; set; }
    [Display(Name = "Date")]
    public DateOnly OrderDate { get; set; }
    [Display(Name = "Payment Method")]
    public string PaymentMethod { get; set; } = null!;

    public int? Quantity { get; set; }
    [Display(Name = "Customer ID")]
    public int? CustomerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
