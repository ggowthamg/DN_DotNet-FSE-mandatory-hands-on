using Retail_Inventory_System.Models;

namespace Retail_Inventory_System.Data
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        IEnumerable<Product> GetAllProducts();
    }
}
