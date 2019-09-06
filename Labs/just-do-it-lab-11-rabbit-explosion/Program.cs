using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace just_do_it_lab_11_rabbit_explosion
{
    class Program
    {
        static void Main(string[] args)
        {

            just_do_it_11_rabbit_explosion.Rabbit_Exponential_Growth(0);
        }
    }
    public class just_do_it_11_rabbit_explosion
    {
        public static (int years, int population) Rabbit_Exponential_Growth(int population = 0)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            List<Rabbit> rabbitList = new List<Rabbit>();
            var rabbitN1 = new Rabbit();
            int iterations = 0;


            while (population <= 400)
            {
                if (rabbitList.Count <= 1)
                {
                    rabbitList.Add(rabbitN1);
                    iterations++;
                    Console.WriteLine($"Created 1 rabbit, total population: {rabbitList.Count}");
                    //int t = population;
                    //rabbitList.Add(rabbitN1);
                    population++;

                    //Console.WriteLine($"Created {rabbitList.Count - t} rabbit, total population: {population}");

                }
                else
                {
                    //int i = population;
                    //int n = rabbitList.Count;
                    // rabbitList.Could is 2 at this point
                    // Meaning that it should generate 2 rabbits
                    // population should be 2 at this point
                    //Console.WriteLine(population);
                    population = population * 2;
                    //Console.WriteLine(population);
                    int rabbitListCount = rabbitList.Count;
                    //Console.WriteLine(rabbitListCount);
                    int i = population;
                    
                    //for (rabbitListCount; rabbitListCount < population; )


                    while (rabbitList.Count < population)
                    {
                        rabbitList.Add(rabbitN1);
                        iterations++;
                        if (rabbitList.Count >= 400) { break; }

                    }


                    //    foreach (Rabbit r in rabbitList)
                    //{
                    population = population * 2;

                    //}
                    int p = rabbitList.Count;
                    Console.WriteLine($"Created {p} rabbits, total population:  {rabbitList.Count}");
                    Thread.Sleep(100);
                    
                }
            }


            //time ends here
            stopWatch.Stop();
            Console.WriteLine($"It took {stopWatch.ElapsedMilliseconds} milliseconds to populate everything");
            return (iterations, rabbitList.Count);
        }
    }
    
    

    class Rabbit
    {
        string Name;
        int Age;
    }
}
