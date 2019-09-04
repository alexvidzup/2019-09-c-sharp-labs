using System;

namespace lab_10_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Method01();
            Method01(5);
            Method01(10, "hello!");
            Method01(25, "Hey There!", true);

            Console.Read();
        }
        static void Method01() { Console.WriteLine("blank"); }

        static void Method01(int x) { Console.WriteLine(x); }

        static void Method01(int x, string y) { Console.WriteLine($"{x} {y}"); }

        static void Method01(int x, string y, bool z) { Console.WriteLine($"{x} {y} {z}"); }
    }
}
