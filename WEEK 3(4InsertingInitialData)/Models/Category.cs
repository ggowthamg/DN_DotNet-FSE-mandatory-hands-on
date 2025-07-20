namespace _4InsertingInitialData.Models
{
    public class Category
    {
        public int Id { get; set; } // Must match table column
        public string CategoryName { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
