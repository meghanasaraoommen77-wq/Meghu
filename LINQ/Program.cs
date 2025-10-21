// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Hello, World!");
class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public string category { get; set; }
    public double price { get; set; }

}
class Program7
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product{ id =1,name="Apple",category="fruits",price=20},
            new Product{ id =2,name="Mango",category="fruits",price=2300},
            new Product{ id =3,name="Banana",category="fruits",price=250},
            new Product{ id =4,name="Potato",category="vegetables",price=2590},
            new Product{ id =5,name="onion",category="vegetables",price=25}

        };
        //Method query
        //1.WHERE
        var expProducts = products.Where(p => p.price > 1);
        foreach (var expProduct in expProducts)
        {
            Console.WriteLine($"{expProduct.name} {expProduct.price}");
        }



        //2.SELECT
        Console.WriteLine("Select ");

        var nameandprice = products.Select(m => new { m.name, m.price });
        foreach (var name in nameandprice)
        {
            Console.WriteLine($"{name.name} {name.price}");
        }

        //3.ORDERBY
        Console.WriteLine("orderby");

        var sortbyprice = products.OrderBy(p => p.price).ToList();
        foreach (var sort in sortbyprice)
        {
            Console.WriteLine($"{sort.name} {sort.price}");
        }

        //4.GROUPBY
        //Keyvaluepair
        Console.WriteLine("groupby");

        var groupbyprice = products.GroupBy(p => p.category);

        foreach (var group in groupbyprice)
        {
            foreach (var p in group)
            {
                Console.WriteLine($"{p.name} {p.category}");
            }

            //5.FIRSTORDEFAULT

            var first = products.FirstOrDefault();
            Console.WriteLine($"First Product:{first?.name}");
            

            //6.LASTORDEFAULT


            var last = products.LastOrDefault();
            Console.WriteLine($"First Product:{last?.name}");

            //Aggregatefuction
            //1.sum
            var sum = products.Sum(p => p.price);
            Console.WriteLine(sum);

            var max = products.Max(p => p.price);
            Console.WriteLine(max);

            var min = products.Min(p => p.price);
            Console.WriteLine(min);

            //var avg = products.Avg(p => p.price);
            //Console.WriteLine(avg);

           // any
    Console.WriteLine("\n");
            bool cheap = products.Any(p => p.price > 100);
            Console.WriteLine(cheap);

            //all
            Console.WriteLine("\n");
            bool allcheap = products.All(p => p.price > 100);
            Console.WriteLine(allcheap);

            //distinct unique data
            Console.WriteLine("\n");
            var distinctcat = products.Select(p => p.category).Distinct();
            foreach (var cat in distinctcat)
            {
                Console.WriteLine(cat);
            }

            //count
            Console.WriteLine("\n");
            int totalcount = products.Count();
            Console.WriteLine(totalcount);

            //conditional count
            Console.WriteLine("\n");
            int conCount = products.Count(p => p.price > 200);
            Console.WriteLine(conCount);

            //intersect/except/union
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mango" };
            List<string> availbale = new List<string> { "Apple", "Carrot", "Mango", "Banana" };

            var intersect = fruits.Intersect(availbale);
            foreach (var f in intersect)
                Console.WriteLine(f);
            Console.WriteLine("\n");

            var except = fruits.Except(availbale);
            foreach (var f in except) Console.WriteLine(f);
            Console.WriteLine("\n");

            var except1 = availbale.Except(fruits);
            foreach (var f in except1) Console.WriteLine(f);
            Console.WriteLine("\n");

            var allitem = fruits.Union(availbale);
            foreach (var f in allitem) Console.WriteLine(f);
            Console.WriteLine("\n");

            //index
            var ele = products.ElementAt(2);
            Console.WriteLine(ele.name);
            Console.WriteLine("\n");

            //contains
            var contain = products.Contains(ele);
            Console.WriteLine(contain);
            Console.WriteLine("\n");

            //take
            var three = products.Take(3);
            foreach (var f in three) 
                Console.WriteLine(f.name);
            Console.WriteLine("\n");

            //skip
            var skip = products.Skip(3);
            foreach (var item in skip)
            {
                Console.WriteLine(item.name);
            }

            //takewhile
            var takewhile = products.TakeWhile(p => p.price > 100);
            foreach (var item in takewhile)
                Console.WriteLine(item.name);
            Console.WriteLine("\n");

            //SKIPwhile
            var skipwhile = products.SkipWhile(p => p.price > 200);
            foreach (var item in skipwhile) 
                Console.WriteLine(item.name);
            Console.WriteLine("\n");


        }

        Console.ReadLine();
        }
    }


