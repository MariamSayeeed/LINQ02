using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Filteration [Restriction] Operators [Where / OfType]
            //1.Filteration Operators [Where / OfType]

            //Get out of stock products

            //Fluent Syntax
            //var result =  ProductList.Where(P => P.UnitsInStock == 0);

            //Query Syntax
            //var result = from P in ProductList
            //             where P.UnitsInStock==0
            //             select P;

            //var result = ProductList.Where(P => P.Category == "Meat/Poultry");

            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;


            //var result = ProductList.Where(P => P.UnitsInStock >0).Where(P => P.Category == "Meat/Poultry");
            //var result = ProductList.Where(P => P.UnitsInStock >0 && P.Category == "Meat/Poultry");

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;

            //Indexed is valid only in fluent syntax

            // var result = ProductList.Where((P,Index)=> Index<10 && P.UnitsInStock == 0);
            //var result = ProductList.Where((P,Index)=> Index < 5);
            //var result = ProductList.Where((P, Index) => Index < 5 && P.UnitsInStock >0);
            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where((P, Index) => Index < 5);


            //OfType
            //ArrayList arrayList = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 2.3m, 4.5m, ProductList[0], ProductList[1] };

            //var result = arrayList.OfType<float>();

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Transformation Operators [Select , SelectMany]

            //2.Transformation Operators [Select , SelectMany] 

            //var result = ProductList.Select(P => P);
            //var result = ProductList.Select(P => P.ProductName);

            //var result = from P in ProductList
            //             select P.ProductName;

            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category=="SeaFood")
            //                         .Select(P => new {Name=P.ProductName,P.Category,OldPrice=P.UnitPrice ,NewPrice=P.UnitPrice-P.UnitPrice*0.1M});


            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "SeaFood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1M

            //             };


            //var result = CustomerList.Select(C=>C.CustomerName);
            //var result = CustomerList.Select(C=>C.Orders);//If one of properties is sequence           
            //var result = CustomerList.SelectMany(C=>C.Orders);//If one of properties is sequence

            //var result = from C in CustomerList
            //             from O in C.Orders
            //             select O;

            //Indexed Select is valid only in Fluent Syntax
            //var result= ProductList.Select((P,I)=>new {I, P.ProductName }).Where(P=>P.I<5);


            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Ordering Operators 

            //Sorting

            //var result= ProductList.OrderBy(P=>P.UnitPrice);
            //var result= ProductList.OrderBy(P => P.UnitPrice).Select(P => new {P.ProductName,P.UnitPrice,P.UnitsInStock});
            //var result = ProductList.OrderBy(P => P.UnitsInStock)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock,
            //    });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .ThenBy(P=>P.UnitPrice)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock,
            //    });    

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .ThenByDescending(P => P.UnitPrice)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock,
            //    });


            //var result = ProductList.Where(P => P.Category=="Meat/Poultry"&&P.UnitsInStock>0)
            //    .OrderBy
            //    .ThenByDescending(P => P.UnitPrice)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock,
            //    });

            //var result = from P in ProductList
            //             where P.Category=="Meat/Poultry"
            //             orderby P.UnitPrice , P.UnitsInStock descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };

            //var result = ProductList.Reverse<Product>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach(var item in ProductList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Elements Operators - Immediate Execution

            //ProductList = new List<Product>();

            //var result =ProductList.First();//May throw an exception [Sequence contains no matching elements]
            //var result =ProductList.Last();//May throw an exception [Sequence contains no matching elements]


            //var result = ProductList.First(P=>P.UnitsInStock==1000);  [Sequence contains no matching elements]
            //var result =ProductList.Last(P=>P.UnitsInStock==0);//May throw an exception [Sequence contains no matching elements]

            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product() { ProductName="Default Product"});        
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000);         
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product { ProductName = "Default Product" });

            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "Default Product" });
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 0);
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000, new Product { ProductName = "Default Product" });

            // var result=ProductList.ElementAt(1);//May throw exception [Index out of range]
            //var result=ProductList.ElementAtOrDefault(1);

            //ProductList= new List<Product>() { new Product () { ProductName = " Only One Product" } };

            //var result = ProductList.Single();//May throw exception 
            //Sequence contains more than one element
            //Sequence contains no element

            //var result = ProductList.Single(P => P.UnitsInStock == 0); //May throw exception 
            //Sequence contains more than one matching element
            //Sequence contains no matching element 

            //var result = ProductList.SingleOrDefault();//May throw exception
            //Sequence contains more than one element
            //Returns default value [null] if the sequence is empty

            //var result = ProductList.SingleOrDefault(new Product() { ProductName="Default Value"});
            //Sequence contains more than one element
            //Returns default value [new Product { ProductName="Default Value"}] if the sequence is empty

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 1000);//May throw exception
            //var result = ProductList.SingleOrDefault(P => P.ProductID == 1);//May throw exception
            //Sequence contains more than one element
            //Returns default value "null" if the sequence is empty

            //var result = ProductList.SingleOrDefault(P => P.UnitsInStock == 0, new Product() { ProductName="Default Value"});
            //var result = ProductList.SingleOrDefault(P => P.ProductID==1, new Product() { ProductName="Default Value"});
            //var result = ProductList.SingleOrDefault(P => P.ProductID==1000, new Product() { ProductName="Default Value"});
            //Sequence contains more than one element
            //Returns default value [new Product { ProductName="Default Value"}] if the sequence is empty

            //var result = ProductList.DefaultIfEmpty(new Product() {ProductName="Default" });
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(result?.ProductName ?? "NA");

            #endregion

            #region Aggregate Operators - Immediate Execution

            //Count - Sum - Max - Min - Avg

            //var result = ProductList.Count(); // 77
            //var result = ProductList.Count; // 77

            //var result = ProductList.Count(P => P.UnitsInStock==0);//5

            //var result = ProductList.Where(P => P.UnitsInStock==0).Count();//5

            //var result = ProductList.Sum(P=>P.UnitPrice); //2222.7100
            //var result = ProductList.Sum(P=>P.UnitsInStock); //3180

            //var result = ProductList.Average(P=>P.UnitPrice); //28.866363636363636363636363636
            //var result = ProductList.Average(P=>P.UnitsInStock); //41.298701298701296

            //Max
            //var result = ProductList.Max();//  $263.50 , Max based on IComparable (Price)

            //var result = ProductList.Max(new ProductComparerUnitsInStock());//  125 , Max based on IComparer (UnitsInStock)
            //var result = ProductList.Max(P=>P.UnitPrice);//$263.5000
            //var result = ProductList.Max(P=>P.UnitsInStock);//125

            //var MaxPrice = ProductList.Max(P=>P.UnitsInStock);//125
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice == MaxPrice);

            //var result = ProductList.MaxBy(P => P.UnitPrice );//Product

            //Min

            //var result = ProductList.Min();
            //var result = ProductList.Min(new ProductComparerUnitsInStock());
            //var result = ProductList.Min(new ProductComparerNameLength());
            //var result = ProductList.Max(new ProductComparerNameLength());

            //var result = ProductList.Min(P=>P.UnitPrice);//2.5000

            //var result = ProductList.MinBy(P => P.ProductName, new ProductComparerNameLength01());//Product
            //var result = ProductList.MaxBy(P => P.ProductName, new ProductComparerNameLength01());//Product

            //Aggregate

            //List<string> Names = new List<string>() { "Ahmed","Ali","Omar", "Osama"};
            //var result = Names.Aggregate((S01, S02) => $"{S01} {S02}");

            //Console.WriteLine(result);

            #endregion

            #region Casting Operator - Immediate Execution 

            //List<Product> list =/*(List<Product>)*/ ProductList.Where(P=>P.UnitsInStock==0);//Invalid
            //List<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long,Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P=>P.ProductID);
            //HashSet<Product> list = ProductList.Where(P => P.UnitsInStock == 0).Where(P => P.UnitsInStock == 0).ToHashSet();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Generation Operators

            //The only way to call this method as -> class member method through "Enumerable" class
            //Range - Empty - Repeat

            //var result = Enumerable.Range(1, 100);
            //var result = Enumerable.Empty<Product>().ToList();

            //result.Add(new Product() { ProductName = "Product01" });
            //result.Add(new Product() { ProductName = "Product02" });

            //var result = Enumerable.Repeat(ProductList[0],3);
            //var result = Enumerable.Repeat(1,3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Set Operators - Union family

            //var Seq01 = Enumerable.Range(1,100);//1--->100
            //var Seq02 = Enumerable.Range(50,100);//50--->149

            //var result = Seq01.Union(Seq02);
            //var result = Seq01.Intersect(Seq02);

            //result= result.Distinct();

            //var result= Seq01.Intersect(Seq02);
            //var result= Seq01.Except(Seq02);
            //var result= Seq02.Except(Seq01);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}

            #endregion

            #region Quantifiers Operators - Returns boolean

            //Any - All - SequenceEqual - Contains

            //var Seq01 = Enumerable.Range(1, 100);//1--->100
            //var Seq02 = Enumerable.Range(1, 100);//1--->100
            //var Seq02 = Enumerable.Range(50, 100);//50--->149

            //Any() --> Returns true if there is at least one element matches the condition 

            //var result = Seq01.Any(N => N % 2 == 0);

            //ProductList = new List<Product>();

            //var result =ProductList.Any();
            //var result =ProductList.Any(P=>P.UnitsInStock==0);


            //All() --> Returns true if all elements match the condition or sequence is empty

            //var result =ProductList.All(P=>P.UnitsInStock==0);
            //var result =ProductList.All(P=>P.UnitPrice>0);

            //SequenceEqual()

            //var result = Seq01.SequenceEqual(Seq02);

            //ProductList.Contains();

            //Console.WriteLine(result);

            #endregion

            #region Zip Operator

            //Zip

            //List<string>Words = new List<string>() { "Ten","Twenty","Thirty", "Fourty"};
            //List<int>Numbers = new List<int>() { 10,20,30,40,50,60};

            //var result = Words.Zip(Numbers,(N,W)=>$"{N} --> {W}");
            //var result = Words.Zip(Numbers, (N, W) => new { Number = N , Word = W });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Grouping Operators

            //var result =ProductList.GroupBy(P => P.Category);

            //var result = from P in ProductList
            //             group P by P.Category;

            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($".........{Product}");
            //    }
            //}

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count()> 5
            //             select new 
            //             {
            //                CategoryName=Category.Key,
            //                CategoryCount=Category.Count(),
            //             };

            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .OrderByDescending(C=> C.Count())
            //                        .Where(C => C.Count() > 5)
            //                        .Select(C => new
            //                        {
            //                            CategoryName = C.Key,
            //                            CategoryCount=C.Count(),
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($".........{Product}");
            //    }
            //}

            #endregion

            #region Partioning Operators [Take - TakeLast - Skip - SkipLast - TakeWhile - SkipWhile]

            //var result =ProductList.Where(P=>P.UnitsInStock==0).Take(3);
            //var result =ProductList.TakeLast(5);

            //var result =ProductList.Skip(5).Take(5);
            //var result =ProductList.SkipLast(5);

            //int[] Numbers = { 6,9,4,1,2,3,4,5};
            //var result= Numbers.TakeWhile(N => N % 3 == 0);
            //var result= Numbers.SkipWhile(N => N % 3 == 0);

            //int[] Numbers = { 5,4,1,3,9,6,7,2,0};
            //var result = Numbers.TakeWhile((N,I) => N > I);
            //var result = Numbers.SkipWhile((N,I) => N > I);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region [Let-Into]

            //Query Syntax only
            //We need to remove vowels 

            //List<string> Names = new List<string>(){"Ahmed","Ali","Mohamed","Mona","Aya","Mariam","Toka","Sally","Mahmoud","Ossama"};

            //var result = from Name in Names
            //             select Regex.Replace(Name, "[aeoiuAEIOU]", string.Empty)
            //             into NoVowelsNames
            //             //Into: Restarts the query with introducing new range variables
            //             where NoVowelsNames.Length > 3
            //             select NoVowelsNames;

            //var result = from Name in Names
            //             let NoVowelsNames=Regex.Replace(Name, "[aeoiuAEIOU]", string.Empty)
            //             //Let : Continue the query with adding new range variables
            //             where NoVowelsNames.Length > 3
            //             select NoVowelsNames;


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result=Regex.Replace("Ahmed","[aeoiuAEIOU]",string.Empty);
            //Console.WriteLine(result);

            #endregion
        }
    }
}
