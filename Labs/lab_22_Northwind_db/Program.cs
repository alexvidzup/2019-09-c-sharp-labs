using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_22_Northwind_db
{
    class Program
    {
        static List<Product> products;
        static List<Category> categories;
        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities())
            {
                products = db.Products.ToList();
            }
            products.ForEach(p =>

                
                Console.WriteLine($"{p.ProductID,-2} {p.ProductName,-30} {p.UnitPrice}"));

            Console.ReadLine();
        }
    }
}
