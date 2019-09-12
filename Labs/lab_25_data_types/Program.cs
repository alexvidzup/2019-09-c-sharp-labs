using System;

namespace lab_25_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // integers
            byte bmin = 0;
            byte msax = 255;

            byte bmin_in_binary = 0b_00000000;
            byte bmax_in_binary = 0b_11111111;

            byte bmin_in_hex = 0x_00;
            byte bmax_in_hex = 0x_ff; // f = 1111 which is 15 in decimal 0 1 2 3 4 5 6 7 8 9 a b c d f

            // byte bnegative_is_invalid = -1

            // letters are also stored as numbers

            char letter01 = 'a';
            Console.WriteLine(letter01);
            Console.WriteLine((int)letter01);

            // CHECK OUT ASCII TABLE which is primitive computers the basic characters set

            // Be aware a STRING is stored as an ARRAY OF CHARACTERS

            string s = "Hello";
            char[] s2 = "Hello".ToCharArray();

            Console.WriteLine($"First letter has index 0 ie {s[0]} and {s2[0]}");


            //whole numbers
            // int
            var numberOfAnyType = 27;

            //int is 32 bits 10101010 10101010 10101010 10101010
            // but! one bit stored has the 'sign' which is either + or -
            // so int has bits for number storage
            // POSITIVE 0 to max-1       0, 1, 2, 3
            // NEGATIVE -1 to max       -1,-2,-3,-4

            Console.WriteLine(int.MaxValue); // prints out 2147483647
            Console.WriteLine(int.MinValue); // prints out -2147483648

            // short

            short short01 = 25; // 16 bits
            //long
            long long01 = 12345534534534521;

            short short02 = 12345;
            int int01 = 1234567890;
            long long02 = 12345678901234567L;

            var lala = 12345678901234567;

            // DECIMAL NUMBERS
            //float 32 bit
            float f = 1.23F;
            //double 64 bits
            double double01 = 1.23D;
            // decimal 128 bits
            decimal decimal01 = 1.23M;

            // floats and doubles are NOT EXACT EVER BECAUSE CONVERT FROM BINARY TO DECIMAL
            double total = 0;
            for (int i = 0; i < 8192; i++)
            {
                total += 0.7;
            }
            Console.WriteLine(total);

            decimal total2 = 0;
            for (int i = 0; i < 8192; i++)
            {
                total2 += 0.7M;
            }
            Console.WriteLine(total2);

            // CARE - WITH MONEY - can avoid errors though by just multiplying by 100,
            // doing the calculation, then dividing by 100 to get answer


            uint positiveInteger = 500;
            Console.WriteLine(uint.MaxValue); // 2 to power 32 (higher than int as 1 bit for + or -)

            // operators

            // a+b=c Expression
            // a, b Operands
            // + operator

            //Unary (one input)
            // Increment 
            int x = 10;
            x++;
            ++x;
            // both of the above add 1
            // in general just use x++; and if possible, use on seperate line
            int y = 1000;
            int z1 = y++; // z1 = 1000 then incriment y1 to 1001
            int z2 = ++y;  // z2 (incriment y2first to 100)
            Console.WriteLine(z1);
            Console.WriteLine(z2);

            // NOT
            Console.WriteLine(!true); // returns false
            Console.WriteLine(!!true); // returns true

            // Binary (two inputs)
            // modulus
            // integer division : take care because int/int = int
            Console.WriteLine(9/4);
            // create a fractional answer => it's easy
            // 9/4  = 2 remainder 1 = 2 1/4
            // integer part : easy : divide integers
            // fractional part : use modulus (remainder) operator
            Console.WriteLine(9%4);

            // Proper division : one number has to be non-integer

            // Ternary operator
            // if (condition) ? return this if true : return if false
            Console.WriteLine(          (10>4)    ?   "high"  :    "low"    );
            Console.WriteLine(          (10<4)    ?   "high"  :    "low"    );

            // Nullable
            int number = 100;
            int? number2 = 1000;
            // mnumber 2 is useful if we read from database and it's possible
            // the box is blank so returns NULL
           //            number = null;    gives exception - can't assign null value to non nullable
            number2 = null;

            // Null coalesce operator : shorthand for
            // if value then return value else return null

            Console.WriteLine("somevalue"??"returnthisifnull");
            Console.WriteLine(null??"returnthisifnull");

            // Default value
            int somenumber = default; // assign 0
            int? somenumber2 = default; // null
            Console.WriteLine(somenumber.ToString(),somenumber2);

            if(somenumber2 == null) Console.WriteLine("it's null"); // it's null

            //  Console.WriteLine(somenumber2??"isnull");  doesn't work


            // bit shift (interest only)
            //          8421
            // watch this binary 1010 is ?? decimal 8 + 0 + 2 + 0 is 10(decimal)
            // shift binary to right >> make half in size 1010 = > 101 which is 5
            // shift        to left << make double        1010=>10100 ie 20
            Console.WriteLine(0b_1010>>1); // 5
            Console.WriteLine(0b_1010<<1); // 20

        }
    }
}
