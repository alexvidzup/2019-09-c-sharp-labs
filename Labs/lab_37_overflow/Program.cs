using System;

namespace lab_37_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            short s = 12345;
            int i = 1234567890;
            long l = 1234567890123456789;
            float f = 123456789012345678901234567890.0123456789012345678901234567890f;
            double d = 123456789012345678901234567890000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000.0123456789012345678901234567890;
            decimal dd = 12345678901234567890123456789.0123456789012345678901234567890m;
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(dd);


            // Default is unchecked overflow 
            unchecked // checked - will give an exception - won't run the code, unchecked won't check - default
            {
                // integer maximums if MAX = 4. 0,1,2,3, -4,-3,-2,-1,0, 1,2,3, -4
                Console.WriteLine(int.MaxValue);
                int bigInt = int.MaxValue;
                bigInt += 1;
                Console.WriteLine(bigInt);
                bigInt += 1;
                Console.WriteLine(bigInt);
                bigInt += 1;
                Console.WriteLine(bigInt);
                bigInt += 1;
                Console.WriteLine(bigInt);
                bigInt += 1;
                Console.WriteLine(bigInt);
            }
            
            DoThis();
        }
        static int counter = 0;
        static void DoThis()
        {
            counter++;
            Console.WriteLine($"Hi {counter}");
            DoThis();
        }
    }
}
