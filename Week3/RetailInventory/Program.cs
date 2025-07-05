using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // LAB 4: INSERT DATA
        if (!await context.Categories.AnyAsync())
        {
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };

            await context.Categories.AddRangeAsync(electronics, groceries);

            var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
            var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

            await context.Products.AddRangeAsync(product1, product2);
            await context.SaveChangesAsync();

            Console.WriteLine("✅ Data inserted successfully!");
        }

        // LAB 5: RETRIEVE DATA
        Console.WriteLine("\n📦 All Products:");
        var allProducts = await context.Products.ToListAsync();
        foreach (var p in allProducts)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");

        Console.WriteLine("\n🔍 Find Product by ID = 1:");
        var productById = await context.Products.FindAsync(1);
        Console.WriteLine(productById != null
            ? $"Found: {productById.Name} - ₹{productById.Price}"
            : "Product not found.");

        Console.WriteLine("\n💸 Find First Product Over ₹50,000:");
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine(expensive != null
            ? $"Expensive Product: {expensive.Name} - ₹{expensive.Price}"
            : "No expensive product found.");
    }
}
