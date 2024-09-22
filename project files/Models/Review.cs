using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int Rating { get; set; }
    [Display(Name = "Date")]
    public DateOnly ReviewDate { get; set; }
    [Display(Name = "Order ID")]
    public int? OrderId { get; set; }

    public virtual Order? Order { get; set; }
}
