using System;
using System.Linq;
using _4InsertingInitialData.Data;

public class RetrieveData
{
    public static void DisplayAllData()
    {
        using (var context = new AppDbContextFactory().CreateDbContext(null))
        {
            var categories = context.Categories.ToList();
            Console.WriteLine("Categories:");
            foreach (var category in categories)
            {
                Console.WriteLine($"Id: {category.Id}, Name: {category.CategoryName}");
            }

            var products = context.Products.ToList();
            Console.WriteLine("\nProducts:");
            foreach (var product in products)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}, CategoryId: {product.CategoryId}");
            }
        }
    }
}
