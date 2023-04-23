using System;
using System.Text.Json.Serialization;

namespace Product.Inventory.Management.API.Models.Product;

public class CreateProductModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("brand_id")]
    public int BrandId { get; set; }

    [JsonPropertyName("supplier_id")]
    public int SupplierId { get; set; }
}

