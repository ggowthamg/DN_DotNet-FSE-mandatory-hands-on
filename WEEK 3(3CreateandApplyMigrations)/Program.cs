using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using _3CreateandApplyMigrations.Data;
using _3CreateandApplyMigrations.Models;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json");

var configuration = builder.Build();

var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

using var context = new AppDbContext(optionsBuilder.Options);

// Seed Data
var electronics = new Category { CategoryName = "Electronics" };
var groceries = new Category { CategoryName = "Groceries" };
await context.Categories.AddRangeAsync(electronics, groceries);

var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };
await context.Products.AddRangeAsync(product1, product2);

await context.SaveChangesAsync();

Console.WriteLine("✅ Initial data inserted successfully.");
