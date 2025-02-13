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

        }
    }
}

