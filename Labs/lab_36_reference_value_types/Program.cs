using System;
using System.Collections.Generic;

namespace lab_36_reference_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRIMITIVE TYPE : int, bool, char, struct
            // STORED IN FAST STACK MEMORY
            // values stored with declaration in live, fast code
            // destroyed immediately as well
            // ==VALUE TYPES as VALUE stored in STACK MEMOTY with declaration
            // var x=10; x and 10 stored on STACK
            // COPY OF VALUE TYPE IS INDEPENDENT
            var x = 10;
            decimal y = x;
            x = 1000;
            y = 3333;
            Console.WriteLine($"x is {x} y is {y}");

            // Pass x,y into a method
            DoThis(x, y);
            Console.WriteLine($"x is {x} y is {y}");

            // pass x, y  BY REFERENCE  into DoThisPermanently(x,y);
            DoThisPermanently(ref x, ref y);

            Console.WriteLine($"x is {x} y is {y}");

            // reference types
            // value types are primitives eg int, held on FAST STACK
            // reference types are LARGE OBJECTS'
            // SHORTCUT = POINTER help of FAST STACK
            // ACTUAL OBJECT held on SLOWER HEAP (LARGER MEMORY)
            // stack                            heap
            // int x=10
            // list<string> myList ---------> {"one", "two"}

            // COPY REFERENCE TYPE : BY default you only the pointer !!!
            int[] myArray = new int[3] { 100, 200, 300 };
            var myArray2 = myArray; // copy pointer only! NOT A NEW OBJECT IN HEAP MEMORY
            Console.WriteLine(string.Join(",", myArray));
            Console.WriteLine(string.Join(",", myArray2));

       

            


            myArray[2] = 5000;
            myArray2[1] = 14000;
            Console.WriteLine(string.Join(",",myArray));
            Console.WriteLine(string.Join(",",myArray2));

            // REFERENCE TYPES NATURALLY ARE TREATED AS GLOBAL WHEN PASSED INTO A METHOD
            var myList = new List<string>() { "first", "second" };
            DoThisToMyList(myList);
            Console.WriteLine(string.Join(",",myList));

            var array3 = myArray2.Clone();
            Console.WriteLine(string.Join(",",array3));

            



        }

        // method to change x and y: x=x^2 and y=> y^3
        static void DoThis(int x, decimal y)
        {
            x = x * x;
            y = y * y * y;
            Console.WriteLine($"x is {x} y is {y}");

        }

        static void DoThisPermanently(ref int x, ref decimal y)
        {
            x = x * x;
            y = y * y * y;
           
        }

        static void DoThisToMyList(List<string> list)
        {
            list.Add("hello");
            list.Add("sir");

        }
    }
}
