using System;
using System.Collections.Generic;

namespace grocery_api.Models;

public partial class Product
{
    public int ProdId { get; set; }

    public string? ProdName { get; set; }

    public int? Price { get; set; }

    public int? CatId { get; set; }

    public virtual Category? Cat { get; set; }
}
