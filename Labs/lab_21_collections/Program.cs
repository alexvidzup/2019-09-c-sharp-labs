using System;
using System.Collections.Generic;
using System.Collections;

namespace lab_21_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] y = new int[5];
           

            // dictionary of KEY-VALUE PAIRS
            // KEY IS INDEX 0,1,2,3,4
            // VALUE IS STRING SAVED
            // pairs 0, "hi"  1, "there"
            var dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "hi");
            dictionary.Add(1, "hi"); // exception
            dictionary.TryAdd(0, "hi");


            // GET VALUES
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine($"{item.Key,-10}{ item.Value}");
            }


            // Queue : enqueue, dequeue, peek, contains

            Queue<int> itemQueue = new Queue<int>();
            for (int i = 0; i < 5; i++)
            {
                itemQueue.Enqueue(i);
            }

            Console.WriteLine(itemQueue.Peek());
            
            itemQueue.Dequeue();
            Console.WriteLine(itemQueue.Peek());
            Console.WriteLine(itemQueue.Dequeue());
            Console.WriteLine(itemQueue.Peek());

            Console.WriteLine(itemQueue.Contains(10));

            //Console.WriteLine(itemQueue.Dequeue());
            //Console.WriteLine(itemQueue.Dequeue());
            //Console.WriteLine(itemQueue.Dequeue());

            // Stack : push, pop, peek, contains
            Console.WriteLine("Stack");
            Stack<int> itemStack = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                itemStack.Push(i);
            }
            Console.WriteLine(itemStack.Peek());
            Console.WriteLine(itemStack.Pop());
            Console.WriteLine(itemStack.Pop());
            Console.WriteLine(itemStack.Pop());
            Console.WriteLine(itemStack.Pop());



            // List : add, Insert, RemoveAt
            Console.WriteLine("Here we are working on a list");
            List<string> itemList = new List<string>();
            int n = 0;
            foreach (var x in itemQueue)
            {
                itemList.Add($"word {n}");
                n++;
                itemList.Insert
            }
            
            foreach (var x in itemList)
            {
                Console.WriteLine(x);
                
            }

            itemList.Insert(1, "inserted word");
            Console.WriteLine("Printing words again");

            
            foreach (var x in itemList)
            {
                Console.WriteLine(x);
                
            }
            itemList.RemoveRange(1, 2);
            Console.WriteLine("Printing list again");
            
            foreach (var x in itemList)
            {
                Console.WriteLine(x);
                
            }


            // Arraylist : cast from object when get data out



            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("potato");
            arrayList.Add(true);
            foreach (var x in arrayList) { Console.WriteLine(x.ToString()); }






            // LinkedList
            LinkedList<int> itemLinkedList = new LinkedList<int>();



            // HashSet
            HashSet<int> itemHashSet = new HashSet<int>();
            itemHashSet.Add(5);


            
        }
    }
}
