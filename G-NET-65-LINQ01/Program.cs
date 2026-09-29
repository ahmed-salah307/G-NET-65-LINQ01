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
            #region Q5
            /*
             
             var filteredProducts = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

foreach (var p in filteredProducts)
{
    Console.WriteLine(p.ProductName);
}
             
             */
            #endregion
            #region Q6
            /*
             
             var customProducts = ProductList.Select(p => new {
    Name = p.ProductName,
    Price = p.UnitPrice,
    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
});

foreach (var item in customProducts)
{
    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
}
             
             
             */
            #endregion
            #region Q7

            /*
             
             
             var indexedProducts = ProductList.Select((p, index) => new { 
    Index = index + 1, 
    Name = p.ProductName 
});

foreach (var item in indexedProducts)
{
    Console.WriteLine($"{item.Index}. {item.Name}");

             
             */

            #endregion
            #region Q8

            /*
             
             
             var sortedList = ProductList
    .OrderBy(p => p.Category)
    .ThenByDescending(p => p.UnitPrice);

foreach (var p in sortedList)
{
    Console.WriteLine($"Category: {p.Category}, Name: {p.ProductName}, Price: {p.UnitPrice}");
}
             
             
             */

            #endregion
            #region Q9

            /*
             
             var beverages = ProductList
    .Where(p => p.Category == "Beverages")
    .OrderByDescending(p => p.UnitsInStock);

foreach (var p in beverages)
{
    Console.WriteLine($"Name: {p.ProductName}, Stock: {p.UnitsInStock}");
}
             
             */

            #endregion
            #region Q10
            /*
             
             var ordersFrom1997 = CustomerList
    .SelectMany(c => c.Orders, (c, o) => new { c.CustomerID, o.OrderDate })
    .Where(x => x.OrderDate.Year >= 1997);

foreach (var order in ordersFrom1997)
{
    Console.WriteLine($"CustomerID: {order.CustomerID}, OrderDate: {order.OrderDate}");
}
             
             */

            #endregion
            #region Q11
            /*
             
             var productWithPosition = ProductList.Select((p, index) => new {
    Position = index + 1,
    p.ProductName
});

foreach (var item in productWithPosition)
{
    Console.WriteLine($"{item.Position}: {item.ProductName}");
}
             
             */

            #endregion
            #region Q12

            /*
             
             String[] Arr = { "aPPLe", "AbAcUs", "bRaNCH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

var sortedWords = Arr
    .OrderBy(w => w.Length)
    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

foreach (var word in sortedWords)
{
    Console.WriteLine(word);
}
             
             */
            #endregion

        }
    }
}
