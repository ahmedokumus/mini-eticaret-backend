using Domain.Entities.Common;

namespace Domain.Entities;

public class Product : BaseEntity
{
    public string? ProductName { get; set; }
    public int? Stock { get; set; }
    public ulong? Price { get; set; }

    public ICollection<Order> Orders { get; set; }
}