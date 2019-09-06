using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace just_do_it_lab11_rabbit_explostion_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeCounter = new Stopwatch();
            timeCounter.Start();
            int populationLimit = 1000;
            int projectedPopulation = 1;
            List<Rabbit> rabbitList = new List<Rabbit>(); // Created new rabbit list
            int rounds = 0;
            var rabbitN1 = new Rabbit("Rabbit0", 0); // created new rabbit

            rabbitList.Add(rabbitN1); // added rabbit to the list

            Console.WriteLine($"At the moment we have {rabbitList.Count} rabbit(s)");

            while (projectedPopulation < populationLimit)
            {
                int populationBeforeReplication = projectedPopulation;

                foreach (Rabbit r in rabbitList)
                {
                    if (r.Age >= 3)
                    {
                        projectedPopulation++;
                    }
                    r.GrowOlder();
                    
                }

                int count = 0;
                //Console.WriteLine($"projected population: {projectedPopulation}");
                while (rabbitList.Count < projectedPopulation)
                {
                    count++;
                    rabbitN1 = new Rabbit("Rabbit" + count, 0);
                    rabbitList.Add(rabbitN1); // creating rabbit
                    rabbitN1.GrowOlder();
                    if (rabbitList.Count >= populationLimit) { break; }
                }
                rounds++;

                int difference = rabbitList.Count - populationBeforeReplication;
                Console.WriteLine($"projected population:{projectedPopulation},made {difference} rabbits this round, current rabbit population: {rabbitList.Count}");
                Thread.Sleep(200);
            }











                timeCounter.Stop();
            Console.WriteLine($"The number of rabbits has reached its population limit ({populationLimit})\nIt took {timeCounter.ElapsedMilliseconds} milliseconds\nIt took: {rounds} rounds");

        }
    }
    public class Rabbit
    {
        public string Name;
        public int Age;
        public void GrowOlder() { this.Age++; }
        public Rabbit(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
