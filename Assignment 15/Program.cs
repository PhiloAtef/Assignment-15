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

            var categoryProductCount = ListGenerators.ProductList.GroupBy

        }
    }
}
