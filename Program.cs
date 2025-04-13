using static Linq2.ListGenerator;
namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region LINQ - Element Operators

            //// 1. Get first Product out of Stock
            //var firstOutOfStockProduct = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine("First product out of stock: " + firstOutOfStockProduct);

            //// 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var firstExpensiveProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine("First product with price > 1000: " + firstExpensiveProduct);

            //// 3. Retrieve the second number greater than 5
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumberGreaterThanFive = arr.Where(n => n > 5).ElementAtOrDefault(1);
            //Console.WriteLine("Second number greater than 5: " + secondNumberGreaterThanFive);

            #endregion

            #region LINQ - Aggregate Operators

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //// 1. Uses Count to get the number of odd numbers in the array
            //var oddNumbersCount = numbers.Count(n => n % 2 != 0);
            //Console.WriteLine("Number of odd numbers: " + oddNumbersCount);

            //// 2. Return a list of customers and how many orders each has.
            //var customerOrderCounts = CustomerList.Select(c => new { c.CustomerName, OrderCount = c.Orders.Length });
            //Console.WriteLine("Customers and their order counts:");
            //foreach (var customer in customerOrderCounts)
            //{
            //    Console.WriteLine($"{customer.CustomerName}: {customer.OrderCount}");
            //}

            //// 3. Return a list of categories and how many products each has
            //var categoryProductCounts = ProductList.GroupBy(p => p.Category)
            //                                       .Select(g => new { Category = g.Key, ProductCount = g.Count() });
            //Console.WriteLine("Categories and their product counts:");
            //foreach (var category in categoryProductCounts)
            //{
            //    Console.WriteLine($"{category.Category}: {category.ProductCount}");
            //}

            //// 4. Get the total of the numbers in an array.
            //var totalSum = numbers.Sum();
            //Console.WriteLine("Total sum of numbers: " + totalSum);

            //// Assuming the file "dictionary_english.txt" is in the same directory as the executable
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //// 5. Get the total number of characters of all words in dictionary_english.txt
            //var totalCharacters = words.Sum(w => w.Length);
            //Console.WriteLine("Total number of characters in dictionary: " + totalCharacters);

            //// 6. Get the length of the shortest word in dictionary_english.txt
            //var shortestWordLength = words.Min(w => w.Length);
            //Console.WriteLine("Length of the shortest word: " + shortestWordLength);

            //// 7. Get the length of the longest word in dictionary_english.txt
            //var longestWordLength = words.Max(w => w.Length);
            //Console.WriteLine("Length of the longest word: " + longestWordLength);

            //// 8. Get the average length of the words in dictionary_english.txt
            //var averageWordLength = words.Average(w => w.Length);
            //Console.WriteLine("Average length of words: " + averageWordLength);

            //// 9. Get the total units in stock for each product category.
            //var totalUnitsInStockByCategory = ProductList.GroupBy(p => p.Category)
            //                                             .Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });
            //Console.WriteLine("Total units in stock by category:");
            //foreach (var category in totalUnitsInStockByCategory)
            //{
            //    Console.WriteLine($"{category.Category}: {category.TotalUnitsInStock}");
            //}

            #endregion

            #region LINQ - Set Operators

            //// 1. Find the unique Category names from Product List
            //var uniqueCategories = ProductList.Select(p => p.Category).Distinct();
            //Console.WriteLine("Unique categories:");
            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}

            //// 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var uniqueFirstLetters = ProductList.Select(p => p.ProductName[0])
            //                                    .Union(CustomerList.Select(c => c.CustomerName[0]))
            //                                    .Distinct();
            //Console.WriteLine("Unique first letters from product and customer names:");
            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            //// 3. Create one sequence that contains the common first letter from both product and customer names.
            //var commonFirstLetters = ProductList.Select(p => p.ProductName[0])
            //                                    .Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //Console.WriteLine("Common first letters from product and customer names:");
            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            //// 4. Create one sequence that contains the first letters of product names that are not

            //// also first letters of customer names.
            //var productFirstLetters = ProductList.Select(p => p.ProductName[0]);
            //var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);
            //var productFirstLettersNotInCustomer = productFirstLetters.Except(customerFirstLetters);
            //Console.WriteLine("First letters of product names not in customer names:");
            //foreach (var letter in productFirstLettersNotInCustomer)
            //{
            //    Console.WriteLine(letter);
            //}

            //// 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var lastThreeCharacters = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
            //                                     .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName));
            //Console.WriteLine("Last three characters of product and customer names:");
            //foreach (var chars in lastThreeCharacters)
            //{
            //    Console.WriteLine(chars);
            //}

            #endregion

            #region LINQ - Quantifiers

            
            //// 2. Return a grouped list of products only for categories that have at least one product that is out of stock.
            //var categoriesWithOutOfStockProducts = ProductList.GroupBy(p => p.Category)
            //                                                  .Where(g => g.Any(p => p.UnitsInStock == 0))
            //                                                  .Select(g => new { Category = g.Key, Products = g.ToList() });
            //Console.WriteLine("Categories with at least one product out of stock:");
            //foreach (var category in categoriesWithOutOfStockProducts)
            //{
            //    Console.WriteLine($"{category.Category}: {string.Join(", ", category.Products.Select(p => p.ProductName))}");
            //}

            //// 3. Return a grouped list of products only for categories that have all of their products in stock.
            //var categoriesWithAllInStockProducts = ProductList.GroupBy(p => p.Category)
            //                                                  .Where(g => g.All(p => p.UnitsInStock > 0))
            //                                                  .Select(g => new { Category = g.Key, Products = g.ToList() });
            //Console.WriteLine("Categories with all products in stock:");
            //foreach (var category in categoriesWithAllInStockProducts)
            //{
            //    Console.WriteLine($"{category.Category}: {string.Join(", ", category.Products.Select(p => p.ProductName))}");
            //}

            #endregion

        
        }
    }
}
