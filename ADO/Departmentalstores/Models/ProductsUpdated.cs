using System;
using System.Collections.Generic;

namespace DepartmentalStores.Models;

public partial class ProductsUpdated
{
    public int ProductId { get; set; }

    public string? ProductSection { get; set; }

    public string? Product { get; set; }

    public decimal? Price { get; set; }

    public decimal? AvailableQuantity { get; set; }
}
