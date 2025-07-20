namespace _4InsertingInitialData.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } // ✅ Added
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
