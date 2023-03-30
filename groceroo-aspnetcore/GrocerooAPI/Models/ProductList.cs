namespace GrocerooAPI.Models
{
    public class ProductList
    {
        public long Id { get; set; }
        public IEnumerable<Product>? Products { get; set;}
        public User? Creator { get; set; }

    }
}
