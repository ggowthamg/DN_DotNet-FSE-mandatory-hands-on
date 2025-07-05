namespace SettingUpDbContext.Models
{
    public class Product
    {
        public int Id { get; set; }                    // Primary key
        public string Name { get; set; } = string.Empty; // Product name
        public decimal Price { get; set; }             // Product price
        public int CategoryId { get; set; }            // Foreign key
        public Category Category { get; set; } = null!;  // Navigation property
    }
}
