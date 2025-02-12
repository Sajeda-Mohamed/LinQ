using LinQ_Session01.Data;
using static LinQ_Session01.Data.ListGenerators;
using System.Linq;
using LinQ_Session01.Data;
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
        }
    }
}
