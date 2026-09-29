namespace G_NET_65_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             
             
             var seafoodProducts = ProductList.Where(p => p.Category == "Seafood");

foreach (var p in seafoodProducts)
{
    Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice}");
}
             
             
             */
            #endregion
            #region Q2
            /*
             
             var productNames = ProductList.Select(p => p.ProductName);

foreach (var name in productNames)
{
    Console.WriteLine(name);
}
             
             */
            #endregion
            #region Q3
            /*
            var sortedProducts = ProductList.OrderBy(p => p.UnitPrice);

            foreach (var p in sortedProducts)
            {
                Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice}");
            }
            */
            #endregion
            #region Q4
            /*
             
             var productsInRange = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

foreach (var p in productsInRange)
{
    Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice}");
}
             
             */


            #endregion
        }
    }
}
