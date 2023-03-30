namespace GrocerooAPI.Models
{
    public class User
    {
        public long Id { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public IEnumerable<ProductList>? ProductLists { get; set; }
    }
}
