using Presentation.Models.Enums;

namespace Presentation.Models;

public class Equipment
{
    public Guid Id { get; }
    public string Name { get; }
    public string Description { get; }
    public Category Category { get; }
    public decimal Price { get; }
    public bool UnderMaintenance { get; }
    public Equipment(Guid id, string name, string description, Category category, decimal price, bool underMaintenance)
    {
        Id = id;
        Name = name;
        Description = description;
        Category = category;
        Price = price;
        UnderMaintenance = underMaintenance;
        
    }

}
