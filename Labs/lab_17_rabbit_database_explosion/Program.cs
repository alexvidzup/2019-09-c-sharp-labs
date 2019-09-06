using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_17_rabbit_database_explosion
{
    class Program
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        static void Main(string[] args)
        {
            
            using (var db = new RabbitDbEntities())
            {
                rabbits = db.Rabbits.ToList();
            }

            Console.WriteLine($"ID Name  AGE");
            PrintRabbits();
            // print each rabbit in tabular form

            // EXPRESSION TO PRINT OUT RABBIT DATA 
            //rabbits.ForEach(rabbit/*names ourselves the variable*/ =>
            //Console.WriteLine($"{rabbit.RabbitId,-5}" + $"{rabbit.Name,-12} {rabbit.AGE}"));


            // // "Proper" longer way to write it out
            //foreach (var rabbit in rabbits)
            //{
            //    Console.WriteLine(($"{rabbit.RabbitId,-5}" + $"{rabbit.Name,-12} {rabbit.AGE}"));
            //}

            //new Rabbit : WPF Textbox01.text ==> use for Agem Name (2 boxes)
            // buttonAdd : run this code

            var newRabbit = new Rabbit()
            {
                AGE = 0,
                Name = $"Rabbit{rabbits.Count + 1}"
            };

            using (var db = new RabbitDbEntities())
            {
                db.Rabbits.Add(newRabbit);
                db.SaveChanges();
            }

            System.Threading.Thread.Sleep(200);



            Console.WriteLine("\n====This is db after making rabbits===\n");

            // read db from stratch


            using (var db = new RabbitDbEntities())
            {
                rabbits = db.Rabbits.ToList();
                PrintRabbits();
                //rabbits.ForEach(rabbit => Console.WriteLine($"{rabbit.RabbitId,-5}" +
                //$"{rabbit.Name,-12} {rabbit.AGE}"));
            }

            Console.ReadLine();
        }
        // Method for printing out the rabbits
        static void PrintRabbits()
        {
            rabbits.ForEach(rabbit => Console.WriteLine($"{rabbit.RabbitId,-5}" +
                $"{rabbit.Name,-12} {rabbit.AGE}"));
        }
    }
}
