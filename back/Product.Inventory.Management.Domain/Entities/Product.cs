
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Inventory.Management.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; } = null!;

    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;


    [Column(TypeName = "jsonb")]
    public Dictionary<string, object>? Properties { get; set; }

}
