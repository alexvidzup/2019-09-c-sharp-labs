using System;
using System.Collections.Generic;
using System.Threading;

namespace just_do_it_lab_11_rabbit_explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = 0;
            List<Rabbit> rabbitList = new List<Rabbit>();
            var rabbitN1 = new Rabbit();
            
            
            
            while (population <= 400)
            {
                if (population < 1)
                {   

                    rabbitList.Add(rabbitN1);
                    population++;
                    Console.WriteLine($"Created {rabbitList.Count} rabbit, total population: {population}");
                    
                }
                else if (population >= 1)
                {
                    //int i = population;
                    //int n = rabbitList.Count;
                    int i = rabbitList.Count;
                    population = population * 2;
                    while (rabbitList.Count <= population)
                    {
                        rabbitList.Add(rabbitN1);
                        
                        if (rabbitList.Count >= 400) { break;}
                        
                    }
                    //    foreach (Rabbit r in rabbitList)
                    //{


                    //}
                    int p = rabbitList.Count - i;
                    Console.WriteLine($"Created {p} rabbits, total population:  {rabbitList.Count}");
                    Thread.Sleep(100);
                }
            }
        }
    }
    class Rabbit
    {
        string Name;
        int Age;
    }
}
