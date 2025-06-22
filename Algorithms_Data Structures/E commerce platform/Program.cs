using System;

class Program
{
    static void Main()
    {
        Product[] products = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Footwear"),
            new Product(3, "Phone", "Electronics"),
            new Product(4, "T-shirt", "Clothing"),
            new Product(5, "Headphones", "Electronics"),
        };

        Console.WriteLine("Linear Search Result:");
        var found1 = SearchService.LinearSearch(products, "Phone");
        Console.WriteLine(found1 != null ? $"Found: {found1.ProductName} ({found1.Category})" : "Product not found");

        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName)); // Required for Binary Search

        Console.WriteLine("\nBinary Search Result:");
        var found2 = SearchService.BinarySearch(products, "Phone");
        Console.WriteLine(found2 != null ? $"Found: {found2.ProductName} ({found2.Category})" : "Product not found");
    }
}
