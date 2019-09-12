
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_23_LINQ
{
    class Program
    {
        static List<Customer> customers;
        static void Main(string[] args)
        {
#if DEBUG
            global::System.Console.WriteLine("We are in debug mode");
            System.Threading.Thread.Sleep(2000);

#endif
            using (var db = new NorthwindEntities1())
            {
                 // LINQ simple query
                // customers = db.Customers.ToList(); not using this line at the moment
                db.Orders.ToList();     // ADDED ORDERS TO WORK WITH ORDERS TABLE
                db.Order_Details.ToList();
                db.Products.ToList();
                   // ADDED THIS TO GET ORDER DETAILS: e.g. products in the orders
                  // cannot print this #
                 // LINQ produces iutput of type IQueryable
                // this is an abstract type so we cast it to a list
                var output1 =
                    (from customer in db.Customers
                     select customer).ToList();
                Console.WriteLine("\n\nTrivial LINQ query : all customers\n");
                output1.ForEach(c => { Console.WriteLine($"{c.CustomerID}"); });

                Console.WriteLine("\n\nLINQ where city is London or BErlin\n");
                var LINQwhere =
                    (from customer in db.Customers
                    where customer.City == "London" || customer.City == "Berlin"
                    select customer).ToList();
                // TO PRINT OUT CUSTOMERS
                //LINQwhere.ToList().ForEach(c => Console.WriteLine($"{c.CustomerID,-10} {c.City}"));
                PrintCustomers(LINQwhere);

                Console.WriteLine("\n\nOrder By Customer Name\n");

                var LINQOrderBy =
                       (from customer in db.Customers
                        where customer.City == "London"
                        orderby customer.ContactName descending
                        select customer).ToList();
                PrintCustomers(LINQOrderBy);

                Console.WriteLine("\n\nLambda has ORderBy..ThenBy\n");
                var LINQORderByThenBy =
                    db.Customers.Where(c => c.City == "London" || c.City == "Berlin" ||
                    c.City == "Paris" || c.City == "Madrid").OrderBy(c => c.City).ThenBy(c => c.ContactName).ToList();
                PrintCustomers(LINQORderByThenBy);

                Console.WriteLine("\n\n Creating A Customer Output Object\n");
                var customObject =
                    from c in db.Customers
                    join order in db.Orders
                        on c.CustomerID equals order.CustomerID
                    select new
                    {
                        Name = c.ContactName,
                        OrderID = order.OrderID, // reason it's grayed out is because it created var name as the grayed in already
                        order.OrderDate,
                        Ship_City = order.ShipCity
                    };
                // manual print
                customObject.ToList().ForEach(item => Console.WriteLine($"{item.Name,-20} {item.OrderID,-10} {item.OrderDate:dd/MM/yyyy}\t{item.Ship_City}"));

                // slick version : print only
                // where city = Berlin
                // print customer name, city, orderID, orderDate
                db.Customers.Where(c => c.City == "Berlin").ToList().ForEach(c => { Console.WriteLine($"{c.ContactName,-10}{c.City,-2}{c.Orders}"); });

                Console.WriteLine("\n\nJoining Orders To Customers Using Lambda\n");
                // select all orders and put in a list
                // but before creating the list, filter it
                // run through the list for every order, find the customer  (joined by CustomerID (already done in entity))
                // and select the ones only where city is berlin
                db.Orders.ToList().Where(o => o.Customer.City == "Berlin").ToList().ForEach(o =>
                  {
                      Console.WriteLine($"{o.Customer.ContactName,-20} {o.Customer.City,-15}{o.OrderID,-15}{o.OrderDate:dd/MM/yyy}");
   
                  });
                // Joining customer with the order and product ID
                Console.WriteLine("\n\nJoining 3 tables: Order details, orders and customers");

                db.Order_Details.Where(od => od.Order.Customer.City == "Berlin").ToList()
                    .ForEach(od =>
                    {
                        Console.WriteLine($"" +
                            $"{od.Order.Customer.ContactName,-20} " +
                            $"{od.Order.Customer.City,-15}" +
                            $"{od.OrderID,-15} " +
                            $"{od.ProductID,-10} " +
                            $"{od.Order.OrderDate:dd/MM/yyy}");
                    });

                // Joining all that with product name as well

                db.Order_Details.Where(od => od.Order.Customer.City == "Berlin").ToList()
                    .ForEach(od =>
                    {
                        Console.WriteLine($"" +
                            $"{od.Order.Customer.ContactName,-20} " +
                            $"{od.Order.Customer.City,-5}" +
                            $"{od.OrderID,-5} " +
                            $"{od.ProductID,-5} " +
                            $"{od.Product.ProductName,-20}" +
                            $"{od.Order.OrderDate:dd/MM/yyy}");
                    });
                Console.ReadLine();
            }

        }
#region PrintBlock

        // Print customers (List<Customer> customers)
        static void PrintCustomers(List<Customer> customers)
        {
            int x = -10;
            // c.Customer.PadRight(x) - to move the text to the right or left, use the longest entry from the info
            var maxCustomerNameLength = customers.Max(c => c.ContactName.Length + 1);
            
            Console.WriteLine("================================================================");
            foreach (Customer c in customers)
            {
                Console.WriteLine($"{c.CustomerID,-10}| {c.ContactName.PadRight(maxCustomerNameLength)}| {c.City}| {c.Phone}");
            }
            Console.WriteLine("=================================================================");
            // a BETTER
            //customers.ForEach(c => Console.WriteLine($"{c.CustomerID,-10} {c.ContactName,-20} {c.City} {c.Phone}"));
        }
    }
#endregion PrintBlock

}
