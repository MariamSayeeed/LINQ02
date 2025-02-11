using static LINQ02.ListGenerator;
using System.Linq;
using System.Threading;
namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);


            #region LINQ - Restriction Operators

            #region 1.Find all products that are out of stock

            //var result = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductList.Where(P=>P.UnitsInStock >0 && P.UnitPrice > 3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            /* //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

             //var result = Arr.Select((name, index) => new { name, index })
             //                .Where(x => x.name.Length < x.index) 
             //                .Select(x => x.index);

             //foreach (var digit in result)
             //{
             //    System.Console.WriteLine(digit);
             //}*/
            #endregion




            #endregion

            ///---------------------------------------------

            #region LINQ - Element Operators 
            // 
            #region 1.Get first Product out of Stock
            //1.Get first Product out of Stock  

            //var result = ProductList.FirstOrDefault(P=> P.UnitsInStock == 0);
            //Console.WriteLine(result); 
            #endregion

            #region 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.Where(P=> P.UnitPrice > 1000).FirstOrDefault();
            //if (result == null) { Console.WriteLine("Null"); }

            #endregion

            #region 3. Retrieve the second number greater than 5 
            ///var result01 = ProductList.Where (P=> P.UnitPrice > 5).ToList();
            /// Console.WriteLine(result01[1]);

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result02 = Arr.Where(i => i > 5).ToArray();
            //Console.WriteLine(result02[1]);

            #endregion

            #endregion

            ///---------------------------------------------

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            ////var result = Arr.Where(N => N % 2 != 0).Count();
            ////Console.WriteLine(result); 
            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var result = from C in CustomerList
            //             select new { Customer = C, OrderCount = C.Orders.Count() };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer: {item.Customer.CustomerName}, Orders: {item.OrderCount}");
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var result = from p in ProductList
            //             group p by p.Category into g 
            //             select new
            //             {
            //                 Category = g.Key,
            //                 ProductCount = g.Count() 
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Count of Products: {item.ProductCount}");
            //}

            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();
            //Console.WriteLine(result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] Arr = File.ReadAllLines("dictionary_english.txt");

            //var result = Arr.Sum(x => x.Length);
            //Console.WriteLine(result);


            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Arr = File.ReadAllLines("dictionary_english.txt");

            //var result = Arr.Min(x => x.Length);
            //Console.WriteLine(result);

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Arr = File.ReadAllLines("dictionary_english.txt");

            //var result = Arr.Max(x => x.Length);
            //Console.WriteLine(result);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Arr = File.ReadAllLines("dictionary_english.txt");

            //var result = Arr.Average(x => x.Length);
            //Console.WriteLine(result);

            #endregion

            #region 9. Get the total units in stock for each product category.
            //var result = from p in ProductList
            //             group p by p.Category into g  
            //             select new
            //             {
            //                 Category = g.Key,
            //                 totalUnit = g.Sum(p => p.UnitsInStock)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock: {item.totalUnit}");
            //}

            #endregion

            #region 10. Get the cheapest price among each category's products
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             select new
            //             {
            //                 Category = g.Key,
            //                 cheapestPrice= g.Min(p => p.UnitPrice)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.cheapestPrice}");
            //}


            #endregion

            ///-------     Let ------------################
            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let cheabestPrice = g.Min(p=> p.UnitPrice)
            //             select new
            //             {
            //                 Category = g.Key,
            //                 cheapestProducts = g.Where(p => p.UnitPrice == cheabestPrice).ToList()
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var product in item.cheapestProducts )
            //    {
            //        Console.WriteLine($"      -> Product: {product.ProductName} ");
            //    }
            //}

            #endregion

            #region 12. Get the most expensive price among each category's products.
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             select new
            //             {
            //                 Category = g.Key,
            //                 MostExpensivePrice = g.Max(p => p.UnitPrice)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category},  Most Expensive Price: {item.MostExpensivePrice}");
            //}

            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let maxPrice = g.Max(p=>p.UnitPrice)
            //             select new
            //             {
            //                 Category = g.Key,
            //                 MostExpensiveProducts = g.Where(p => p.UnitPrice == maxPrice).ToList()
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var product in item.MostExpensiveProducts)
            //    {
            //        Console.WriteLine($"      -> Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}


            #endregion

            #region 14. Get the average price of each category's products.
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             select new
            //             {
            //                 Category = g.Key,
            //                 MostExpensivePrice = g.Average(p => p.UnitPrice)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category},  Average  Price: {item.MostExpensivePrice}");
            //}

            #endregion

            #endregion

            ///---------------------------------------------

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name
            //string [] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

            //var result = Arr.OrderBy(x => x);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /* //var result02 = ProductList.OrderBy(P=>P.ProductName).ToList();
             //foreach (var item in result02)
             //{
             //    Console.WriteLine(item);
             //}*/

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w, new CaseInsensitiveComparer());

            //foreach (string w in result)
            //{
            //    Console.WriteLine(w);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var result = ProductList.OrderByDescending(P => P.UnitPrice).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(x => x.Length).ThenBy(x=>x).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x=>x.Length).ThenBy(w => w, new CaseInsensitiveComparer());

            //foreach (string w in result)
            //{
            //    Console.WriteLine(w);
            //}


            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProductList.OrderBy(p=>p.Category).ThenByDescending(p=>p.UnitPrice).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x.Length).ThenByDescending(w => w, new CaseInsensitiveComparer());

            //foreach (string w in result)
            //{
            //    Console.WriteLine(w);
            //}

            #endregion

            //---------#####################################
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(x => x[1]=='i').OrderBy(x => x).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #endregion

            ///---------------------------------------------

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            //var result = ProductList.Select(p=> p.ProductName).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(x=>
            //                                new { Lower = x.ToLower() ,
            //                                      Upper = x.ToUpper()  
            //                                    }
            //                                ).ToList();

            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}


            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductList.Select(p => new { p.ProductID, p.ProductName, Price = p.UnitPrice });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr
            //.Select((value, index) => new { Value = value, Index = index }) 
            //.Where(x => x.Value == x.Index).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Value: {item.Value}, Index: {item.Index}");
            //}


            /////---  Another Solution --------
            /* //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

             //Console.WriteLine("Number: In-Place?");
             //for (int i = 0; i < Arr.Length; i++)
             //{
             //    if (Arr[i] == i)
             //    {
             //        Console.WriteLine($"{Arr[i]}: True");
             //    }

             //    else
             //    {
             //        Console.WriteLine($"{Arr[i]}: False");
             //    }
             //}*/


            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA.SelectMany(a=> numbersB, (a , b) => new {A=a , B =b}).Where(p=> p.A < p.B).ToList();

            //Console.WriteLine("Pairs Where a < b:");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}

            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var result = from c in CustomerList
            //                            from o in c.Orders
            //                            where o.Total < 500
            //                            select o;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.

            //var result = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1998
            //             select o;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"OdrerID: {item.OrderID}, Date: {item.OrderDate}, Total : {item.Total}");
            //}

            #endregion

            #endregion

            ///---------------------------------------------

            #region LINQ - Set Operators















            #endregion

            ///---------------------------------------------

            #region LINQ - Partitioning Operators

            #endregion

            ///---------------------------------------------

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] Arr = File.ReadAllLines("dictionary_english.txt");

            //var result = Arr.Any();
            //Console.WriteLine(result);


            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var result = ProductList.GroupBy(p=>p.Category).Where(g=> g.Any(p=>p.UnitsInStock==0));

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"   Product: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //    }
            //}


            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var result = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock != 0));

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"   Product: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //    }
            //}

            #endregion

            #endregion

            ///---------------------------------------------

            #region LINQ – Grouping Operators








            #endregion

        }
    }
}
