using System;

namespace draft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static char GetGrade(int s1, int s2, int s3)
        {
            //Your code goes here...
            int s = (s1 + s2 + s3) / 3;
            if (s>=90) { return 'A'; }
            else if (s>=80) { return 'B'; }
            else if (s>=70) { return 'C'; }
            else if (s>=60) { return 'D'; }
            else { return 'F'; }



            
        }

        }
    




}
