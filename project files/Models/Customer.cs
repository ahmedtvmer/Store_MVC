using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public partial class Customer
{
    public int CustomerId { get; set; }
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;
    [Display(Name = "Email")]
    public string Email { get; set; } = null!;
    public int? Age { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
