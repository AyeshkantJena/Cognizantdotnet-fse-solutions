using System;
using System.Collections.Generic;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
    }
}

public class ProductSearch
{
    // Linear Search
    public static Product? LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    // Binary Search (requires sorted array by ProductName)
    public static Product? BinarySearch(Product[] products, string name)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int comparison = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return products[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    // Helper to sort products by name
    public static void SortProductsByName(Product[] products)
    {
        Array.Sort(products, (a, b) => string.Compare(a.ProductName, b.ProductName, StringComparison.OrdinalIgnoreCase));
    }

    public static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shirt", "Clothing"),
            new Product(3, "Book", "Education"),
            new Product(4, "Phone", "Electronics"),
            new Product(5, "Shoes", "Footwear")
        };

        string searchName = "Phone";

        Console.WriteLine("🔍 Linear Search:");
        var result1 = LinearSearch(products, searchName);
        Console.WriteLine(result1 != null ? result1.ToString() : "Product not found");

        Console.WriteLine("\n🔍 Binary Search:");
        SortProductsByName(products);  // must be sorted before binary search
        var result2 = BinarySearch(products, searchName);
        Console.WriteLine(result2 != null ? result2.ToString() : "Product not found");
    }
}