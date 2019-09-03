using System;
using System.Collections.Generic; //list

namespace lab_5_rabbits
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Rabbit> rabbits = new List<Rabbit>();
            
            // count from 1 to 10
            for (int n = 1; n <= 20; n++)
            {

                var r = new Rabbit();
                r.Age = n;
                if (n < 10)
                {
                    r.Name = "Rabbit" + 0 + n;
                }
                else
                {
                    r.Name = $"Rabbit{n}";
                }



                rabbits.Add(r);

            }
            foreach (Rabbit r in rabbits) 
            {
                Console.WriteLine($"Rabbit is {r.Age} years old and it's name is {r.Name}");
            }

            // create Rabbits

            // name = "Rabbit" + 0 + i 	Rabbit01, Rabbit02, Rabbit03
            // age = i 
            // add to list of rabbits
            // print out list at end
            Console.ReadLine();
        }
    }
    public class Rabbit
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
