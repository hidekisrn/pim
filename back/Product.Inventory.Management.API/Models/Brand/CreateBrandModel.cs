using System;
using System.Text.Json.Serialization;

namespace Product.Inventory.Management.API.Models.Brand;

public class CreateBrandModel
{
	[JsonPropertyName("name")]
	public string Name { get; set; }
}

