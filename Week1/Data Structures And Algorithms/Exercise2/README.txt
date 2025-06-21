Logic for Exercise 2
---------------------------------------------------------------


Step 1: Understanding Big O Notation
Big O Notation describes the performance (time or space complexity) of an algorithm as input size increases.

Example:

Linear Search: O(n)

Binary Search: O(log n)

It helps us compare how different algorithms scale with data size.

Step 2: Setup – Creating Product Class
Product class holds attributes like ProductId, ProductName, and Category.

The ToString() method returns a human-readable string for the product.

Step 3: Implementation
Linear Search
Scans each product in the array from start to end.

Compares each product's name with the search term (case-insensitive).

If found, returns that Product; otherwise, returns null.

Binary Search
Requires the array to be sorted by ProductName.

Uses a divide-and-conquer method:

Calculates mid index.

Compares mid element’s name with the target.

Narrows the search to left or right half accordingly.

Much faster for large sorted arrays.

Sorting
A helper method SortProductsByName sorts the product array alphabetically using Array.Sort().

Step 4: Execution in Main()
1. Product Array Created

Product[] products = new Product[] { ... };
5 sample products are created and stored in an array.

2. Linear Search

Product linearResult = LinearSearch(products, "Phone");
Each product is checked one by one.

When "Phone" is found, it's returned and displayed.

3. Binary Search

SortProductsByName(products); // Sort before binary search
Product binaryResult = BinarySearch(products, "Phone");
Array is sorted alphabetically by name.

Binary search quickly finds "Phone" in fewer comparisons.


--------------------------------------------------------------------------------------

