using LinQ_Session01.Data;
using static LinQ_Session01.Data.ListGenerators;
using static LinQ_Session01.Data.Customer;
using static LinQ_Session01.Data.Order;
using static LinQ_Session01.Data.Product;
using System.Linq;
using LinQ_Session01.Data;
using Microsoft.VisualBasic;
using System.Buffers.Text;
using System.Text.RegularExpressions;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
namespace LinQ_Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            /*1*/ //var Result = ProductList.Where(P => P.UnitsInStock == 0);
            /*2*/ //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
            ///*3*/ var Numbers = new Dictionary<int, string>
            //      {
            //          { 1, "One" }, { 2, "Two" }, { 3, "Three" }, { 4, "Four" },
            //          { 5, "Five" }, { 6, "Six" }, { 7, "Seven" }, { 8, "Eight" }, { 9, "Nine" }
            //      };
            //var Result = Numbers.Where(N => N.Value.Length < N.Key);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Element Operators
            /*1*/ //var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            /*2*/ //var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 3000);
            ///*3*/ int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(N => N > 5)
            //             .Skip(1).FirstOrDefault();
            //Console.WriteLine(Result);
            #endregion

            #region Aggregate Operators
            #region 1
            ///*1*/ int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(N => N % 2 == 1); 
            #endregion

            #region 2
            ///*2*/ var Result = CustomerList.Where(C => C .Orders.Count() > 0).ToList();               
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item}-------------- {item.Orders.Count()}");
            //} 
            #endregion

            #region 3
            ///*3*/    var Result = ProductList.GroupBy(p => p.Category).ToDictionary(g => g.Key, g => g.Count());
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Key}\t{item.Value}");
            //} 
            #endregion

            #region 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Length;
            //Console.WriteLine(Result);
            #endregion

            #region 5
            //string[] words = File.ReadAllLines(@"C:\Users\hp\Downloads\dictionary_english.txt");

            //if (words.Length == 0)
            //{
            //    Console.WriteLine("The dictionary file is empty.");
            //    return;
            //}
            //int totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine($"Total number of characters: {totalCharacters}");

            #endregion

            #region 6
            //string[] words = File.ReadAllLines(@"C:\Users\hp\Downloads\dictionary_english.txt");

            //if (words.Length == 0)
            //{
            //    Console.WriteLine("The dictionary file is empty.");
            //    return;
            //}
            //int shortestWordLength = words.Min(word => word.Length);
            //Console.WriteLine($"Length of the shortest word: {shortestWordLength}");

            #endregion

            #region 7
            //string[] words = File.ReadAllLines(@"C:\Users\hp\Downloads\dictionary_english.txt");

            //if (words.Length == 0)
            //{
            //    Console.WriteLine("The dictionary file is empty.");
            //    return;
            //}
            //int longestWordLength = words.Max(word => word.Length);
            //Console.WriteLine($"Length of the longest word: {longestWordLength}");
            #endregion

            #region 8
            //string[] words = File.ReadAllLines(@"C:\Users\hp\Downloads\dictionary_english.txt");

            //if (words.Length == 0)
            //{
            //    Console.WriteLine("The dictionary file is empty.");
            //    return;
            //}
            //double averageWordLength = words.Average(word => word.Length);
            //Console.WriteLine($"Average length of words: {averageWordLength}");
            #endregion

            #region 9
            //var Result = ProductList.GroupBy(P => P.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //}).ToList();            
            #endregion

            #region 10
            //var Result = ProductList.GroupBy(P => P.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Min(p => p.UnitPrice)
            //}).ToList();
            #endregion

            #region 11
            //var Result = ProductList.GroupBy(P => P.Category).Select(g =>
            //{
            //    var cheapestPrice = g.Min(p => p.UnitPrice);
            //    var cheapestProducts = g.Where(p => p.UnitPrice == cheapestPrice).ToList();
            //    return new
            //    {
            //        Category = g.Key,
            //        CheapestPrice = cheapestPrice,
            //        Products = cheapestProducts
            //    };
            //}).ToList();  
            #endregion

            #region 12
            //var mostExpensivePrices = ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //         Category = g.Key,
            //         MostExpensivePrice = g.Max(p => p.UnitPrice)
            //    }).ToList();
            //foreach (var item in mostExpensivePrices)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Most Expensive Price: {item.MostExpensivePrice}");
            //}
            #endregion

            #region 13
            //var productsWithMostExpensivePrice = ProductList.GroupBy(p => p.Category)
            //    .SelectMany(g => g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice))).ToList();
            //foreach (var product in productsWithMostExpensivePrice)
            //{
            //    Console.WriteLine(product.ToString());
            //}
            #endregion

            #region 14
            //var averagePricesByCategory = ListGenerators.ProductList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    }).ToList();
            //foreach (var item in averagePricesByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice}");
            //}
            #endregion
            #endregion

            #region  Ordering Operators
            #region 1
            //var sortedByName = ProductList.OrderBy(p => p.ProductName).ToList();
            //foreach (var product in sortedByName)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion

            #region 2
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr = arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3
            //var sortedByStock = ProductList.OrderByDescending(p => p.UnitsInStock).ToList();
            //foreach (var product in sortedByStock)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Stock: {product.UnitsInStock}");
            //}
            #endregion

            #region 4
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var sortedByLengthThenAlphabet = arr.OrderBy(word => word.Length).ThenBy(word => word, 
            //    StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var word in sortedByLengthThenAlphabet)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 5
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedByLengthThenCaseInsensitive = arr.OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var word in sortedByLengthThenCaseInsensitive)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 6
            //var sortedByCategoryThenPrice = ListGenerators.ProductList.OrderBy(p => p.Category)
            //            .ThenByDescending(p => p.UnitPrice).ToList();
            //foreach (var product in sortedByCategoryThenPrice)
            //{
            //    Console.WriteLine($"Category: {product.Category}, Price: {product.UnitPrice}");
            //}
            #endregion

            #region 7
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedByLengthThenDescending = arr.OrderBy(word => word.Length).ThenByDescending
            //    (word => word, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var word in sortedByLengthThenDescending)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 8
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = arr.Where(word => word.Length > 1 && word[1] == 'i').Reverse().ToList();
            //foreach (var word in Result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #endregion

            #region Transformation Operators
            #region 1
            //var Result = ProductList.Select(p => p.ProductName).ToList();
            //foreach (var name in Result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var transformedWords = words.Select(word => new { Upper = word.ToUpper(), Lower 
            //    = word.ToLower() }).ToList();
            //foreach (var word in transformedWords)
            //{
            //    Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
            //}           
            #endregion

            #region 3
            //var productDetails = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice, 
            //    p.Category }).ToList();
            //foreach (var product in productDetails)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.Price}, Category: {product.Category}");
            //}
            #endregion

            #region 4
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var matchingIndexes = arr.Select((value, index) => new { Value = value, Index = index })
            //    .Where(item => item.Value == item.Index).ToList();
            //foreach (var item in matchingIndexes)
            //{
            //    Console.WriteLine($"Value {item.Value} matches its index {item.Index}");
            //}
            #endregion

            #region 5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { A = a, B = b };
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"({pair.A}, {pair.B})");
            //}
            #endregion

            #region 6
            //var smallOrders = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500.00M);
            //foreach (var order in smallOrders)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Total: {order.Total}");
            //}
            #endregion

            #region 7
            //var recentOrders = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            //foreach (var order in recentOrders)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Date: {order.OrderDate}, Total: {order.Total}");
            //}
            #endregion
            #endregion

            #region Set Operators
            #region 1
            //var uniqueCategories = ProductList.Select(p => p.Category).Distinct();
            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region 2
            //var productFirstLetters = ProductList.Select(p => p.ProductName[0]);
            //var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);
            //var uniqueFirstLetters = productFirstLetters.Union(customerFirstLetters);

            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 3
            //var productFirstLetters = ProductList.Select(p => p.ProductName[0]);
            //var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);
            //var commonFirstLetters = productFirstLetters.Intersect(customerFirstLetters);
            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 4
            //var productFirstLetters = ProductList.Select(p => p.ProductName[0]);
            //var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);
            //var commonFirstLetters = productFirstLetters.Except(customerFirstLetters);
            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 5
            //var productLastThreeChars = ProductList.Select(p => p.ProductName.Length >= 3 ? 
            //         p.ProductName[^3..]: p.ProductName);
            //var customerLastThreeChars = CustomerList.Select(c => c.CustomerName.Length >= 3 ?
            //         c.CustomerName[^3..]: c.CustomerName);
            //var lastThreeCharsSequence = productLastThreeChars.Concat(customerLastThreeChars);
            //foreach (var lastThree in lastThreeCharsSequence)
            //{
            //    Console.WriteLine(lastThree);
            //}
            #endregion
            #endregion

            #region Quantifiers
            #region 1
            //string[] words = File.ReadAllLines(@"C:\Users\hp\Downloads\dictionary_english.txt");
            //var wordsContainingEi = words.Where(word => word.Contains("ei")).ToList();
            //if (wordsContainingEi.Any())
            //{
            //    Console.WriteLine("Words containing 'ei' found:");
            //    foreach (var word in wordsContainingEi)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No words contain 'ei'.");
            //}
            #endregion

            #region 2
            //var groupedProducts = ProductList.Where(p => p.UnitsInStock == 0).Select(p => p.Category)
            //               .Distinct().Join(ProductList,cat => cat, prod => prod.Category,(cat, prod)
            //               => new { Category = cat, Product = prod }).GroupBy(x => x.Category);
            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  - {product.Product.ProductName} (Stock: {product.Product.UnitsInStock})");
            //    }
            //}
            #endregion

            #region 3
            //var fullyStockedCategories = ProductList.GroupBy(p => p.Category).Where
            //    (g => g.All(p => p.UnitsInStock > 0)).ToList();
            //foreach (var category in fullyStockedCategories)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"  - {product.ProductName} (Stock: {product.UnitsInStock})");
            //    }
            //}
            #endregion
            #endregion
        }
    }
}

