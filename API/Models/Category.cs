using System;
using System.Collections.Generic;

namespace grocery_api.Models;

public partial class Category
{
    public int CatId { get; set; }

    public string? CatName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
