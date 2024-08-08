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

            #region 18
            //var uniqueCategory = ListGenerators.ProductList.Distinct();
            //foreach (var item in uniqueCategory)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 19
            //var uniqueFirstLetters = ListGenerators.CustomerList.Select(c => c.CustomerName[0]).Union(ListGenerators.ProductList.Select(p => p.ProductName[0])).Distinct().ToList();
            //foreach (var item in uniqueFirstLetters)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 20
            //var commonFirstLetters = ListGenerators.CustomerList.Select(c => c.CustomerName[0]).Intersect(ListGenerators.ProductList.Select(p => p.ProductName[0])).ToList();
            //foreach (var item in commonFirstLetters)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 21
            //var productFirstLettersNotInCustomer = ListGenerators.ProductList.Select(p => p.ProductName[0]).Except(ListGenerators.CustomerList.Select(c => c.CustomerName[0])).ToList();
            //foreach (var item in productFirstLettersNotInCustomer)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 22
            //var lastThreeCharacters = ListGenerators.ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)).Concat(ListGenerators.CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3))).ToList();
            //foreach (var item in lastThreeCharacters)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 23
            //var first3Orders = ListGenerators.CustomerList.Where(p => p.Region != null ? p.Region.Equals("WA") : false).Take(3);
            //foreach (var item in first3Orders)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 24
            //var skip2Orders = ListGenerators.CustomerList.Where(p => p.Region != null ? p.Region.Equals("WA") : false).Skip(2);
            //foreach (var item in skip2Orders)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            //Array for next 3 question
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            #region 25
            //var takeUntil = numbers.TakeWhile((n, i) => n > i);
            //foreach (var item in takeUntil)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 26
            //var skipUntil = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var item in skipUntil)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 27
            //var skipUntil2 = numbers.SkipWhile((n, i) => n > i);
            //foreach (var item in skipUntil2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 28
            //var containsEi = words.Any(w => w.Contains("ei"));
            //Console.WriteLine(containsEi); 
            #endregion

            #region 29
            //var allProductsInStockByCategory = ListGenerators.ProductList.GroupBy(p => p.Category).Where(c => c.All(p => p.UnitsInStock > 0)).Select(p => new
            //{
            //    Category = p.Key,
            //    Products = p.ToList()
            //}).ToList();

            //allProductsInStockByCategory.ForEach(c =>
            //{
            //    Console.WriteLine($"\n{c.Category}\n===================================================");
            //    c.Products.ForEach(Console.WriteLine);
            //}); 
            #endregion

            #region 30
            //var anyProductsOutOfStockByCategory = ListGenerators.ProductList.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock == 0)).Select(p => new
            //{
            //    Category = p.Key,
            //    Products = p.ToList()
            //}).ToList();

            //anyProductsOutOfStockByCategory.ForEach(c =>
            //{
            //    Console.WriteLine($"\n{c.Category}\n===================================================");
            //    c.Products.ForEach(Console.WriteLine);
            //}); 
            #endregion


        }
    }
}
