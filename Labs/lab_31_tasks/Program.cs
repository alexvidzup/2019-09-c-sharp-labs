using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace lab_31_tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            // anonymus (lambda) delegate
            var task01 = new Task(() => {
                Console.WriteLine("running task01");
            });
            task01.Start();

            // delegate is PLACEHOLDER FOR ONE OR MORE METHODS
            // simplest DELEGATE is called ACTION
            // ACTION     void DoThis(){} // no parameteres in and void output

            var task01d = new Task( /* named Delegate in here */   DoThis);
            task01d.Start();

            var task02 = Task.Run(() =>
           {
               Console.WriteLine("running task02");
           });

            var taskArray = new Task[10];
            taskArray[0] = Task.Run(() => { Console.WriteLine("Task array 00"); });
            taskArray[1] = Task.Run(() => { Console.WriteLine("Task array 01"); });
            taskArray[2] = Task.Run(() => { Console.WriteLine("Task array 02"); });

            var counter = 0;
            for (int i = 3; i < 10; i++)
            {
                taskArray[i] = Task.Run(() => { Console.WriteLine($"Task array {counter}"); });
                //System.Threading.Thread.Sleep(10);
                counter++;
            }

            Task.WaitAny(taskArray);

            // Console.ReadLine();

            var s1 = new Stopwatch();
            s1.Start();

            // Parallel ForEach
            var myList = new List<string> { "a", "b", "c", "d","e","f","g","h"};
            // take 150 ms ie 3 loops in SERIAL
            myList.ForEach((s) => {
                Console.WriteLine($"Item is {s}");
                System.Threading.Thread.Sleep(50);
            });

            s1.Stop();
            Console.WriteLine($"took {s1.ElapsedMilliseconds}");

            var s2 = new Stopwatch();
            s2.Start();

            // Execute in parallel
            Parallel.ForEach(myList, (s) =>
            {
                Console.WriteLine($"Parallel item is {s}");
                System.Threading.Thread.Sleep(50);
            });

            s2.Stop();
            Console.WriteLine($"took {s2.ElapsedMilliseconds}");

            // assigning time to seperate variable makes it work when working out % speed of processing
            decimal num1 = s1.ElapsedMilliseconds;
            decimal num2 = s2.ElapsedMilliseconds;
            
            decimal diff = ((num1 / num2)) * 100;

            Console.WriteLine($"Parallel process is {Math.Floor(diff)}% faster!");


            // PLINQ Parallel LINQ
            var outputASPARALLEL =
                (from item in myList
                 select item).AsParallel().ToList();


            // Getting data back from a task
            // var t = Task.Run(   ()=>{}   );
            // var t = Task<T>.Run...       return data of Type T
            // access data t.Result

            var taskWithResult = Task<int>.Run(() => {
                return 100;
            });

            // taskWithResult.Wait();
            Console.WriteLine($"Result of our task is {taskWithResult.Result}");

            Console.ReadLine();
        }
        static void DoThis () { Console.WriteLine("I am doing something"); }
    }
}
