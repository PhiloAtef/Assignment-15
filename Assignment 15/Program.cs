using ASSLINQ;

namespace Assignment_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //var firstOutOfStock = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(firstOutOfStock); 
            #endregion

            #region 2
            //var firstPriceOver1000 = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice>1000M, null);
            //if (firstPriceOver1000 == null)
            //{
            //    Console.WriteLine("Null");
            //}
            //else
            //{
            //    Console.WriteLine(firstPriceOver1000);
            //} 
            #endregion

            #region 3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var secondNumberGreaterThan5 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(secondNumberGreaterThan5); 
            #endregion


            #region 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddCount = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine(oddCount); 
            #endregion

            #region 5
            //var customerOrdersCount = ListGenerators.CustomerList.Select(c => new { c.CustomerName, OrderCount = c.Orders.Count() }).ToList();

            //foreach (var item in customerOrdersCount)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 6
            //var categoryProductCount = from p in ListGenerators.ProductList
            //                           group p by p.Category
            //                           into pc
            //                           select new { Category = pc.Key, Count = pc.Count() };

            //foreach (var item in categoryProductCount) 
            //{
            //    Console.WriteLine($"{item.Category} => {item.Count}");
            //} 
            #endregion

            #region 7
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var sum = Arr.Sum();
            //Console.WriteLine(sum);
            //var otherSum = Arr.Aggregate((num1, num2) => num1 + num2);
            //Console.WriteLine(otherSum); 
            #endregion

            //reading textfile dictionary
            var words = File.ReadAllLines("dictionary_english.txt");

            #region 8
            //var totalCharacters = words.Sum(w => w.Length);
            //Console.WriteLine(totalCharacters); 
            #endregion

            #region 9
            //var shortestWordLength = words.Min(w => w.Length);
            //Console.WriteLine(shortestWordLength);
            #endregion

            #region 10
            //var longestWordLength = words.Max(w => w.Length);
            //Console.WriteLine(longestWordLength); 
            #endregion

            #region 11
            //var averageWordLength = words.Average(w => w.Length);
            //Console.WriteLine(averageWordLength); 
            #endregion

            #region 12
            //var totalUnitsInStockByCategory = ListGenerators.ProductList.GroupBy(p => p.Category).Select(c => new { Category = c.Key, TotalUnitsInStock = c.Sum(p => p.UnitsInStock) }).ToList();

            //foreach (var item in totalUnitsInStockByCategory) 
            //{ 
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 13
            //var cheapestPriceByCategory = ListGenerators.ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    Category = c.Key,
            //    Cheapest_Price = c.Min(p => p.UnitPrice)
            //});

            //foreach (var item in cheapestPriceByCategory)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 14
            //var cheapestProds = from p in ListGenerators.ProductList
            //                    group p by p.Category
            //                          into pc
            //                    let minPriceProduct = pc.MinBy(p => p.UnitPrice)
            //                    select minPriceProduct;

            //foreach (var item in cheapestProds)
            //{
            //    Console.WriteLine(item);
            //}    
            #endregion

            #region 15
            //var mostExpensivePriceByCategory = ListGenerators.ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    Category = c.Key,
            //    Price = c.Max(p => p.UnitPrice)
            //}).ToList();

            //foreach (var item in mostExpensivePriceByCategory) 
            //    Console.WriteLine(item); 
            #endregion

            #region 16
            //var expensiveProds = from p in ListGenerators.ProductList
            //                     group p by p.Category
            //                           into pc
            //                     let maxPriceProduct = pc.MaxBy(p => p.UnitPrice)
            //                     select maxPriceProduct;

            //foreach (var item in expensiveProds)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 17
            //var avgInCategory = ListGenerators.ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    Category = c.Key,
            //    Price = c.Average(p => p.UnitPrice)
            //});
            //foreach (var item in avgInCategory)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
        }

    }
}
