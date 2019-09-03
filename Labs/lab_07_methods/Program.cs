using System;

namespace lab_07_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThisEveryday();
            // method INSIDE method
            DoThisAswell();
            var m = new Mammal();
            m.GetOlder(); // increase age by 1
            void DoThisEveryday()
            {
                Console.WriteLine("I am doing this");

            }

            CountNum(5000); // y only
            CountNum(5000, 300);


            OutParameters(10, 10, out int a);
            Console.WriteLine($"output: {a}");

            TupleMethod();   // not gathering the output
            var tupleOutput = TupleMethod(); // OUTPUT sent to custom object
            Console.WriteLine($"tupleOutputs are {tupleOutput.x}, {tupleOutput.y}, {tupleOutput.z}");
            
        }
        static void DoThisAswell()
        {
            Console.WriteLine("I am doing something too!");
        }
        static void CountNum (int y, int x = 100)
        {
            Console.WriteLine(x * y);
        }

        static void OutParameters (int x, int y, out int z)
        {
            z = x * y; // Will return this as z
        }

        static (int x, string y, bool z) TupleMethod()
        {
            return (10, "hi", false);
        }
    }
    class Mammal
    {
        public int Age { get; set; }
        //Instance method
        public void GetOlder() { Age++; }
    }
}
