namespace GrocerooAPI.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }

        public Product (long id, string? name, string? description, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

    }
}
