using System;

namespace lab_15_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string x = "Hello World";
            if (x.StartsWith("hello"))
            {
                Console.WriteLine("World");

            }
            x = x.AmazingExtraStringMethod();
            Console.WriteLine(x);
        }
        


    }
    abstract public class Holiday
    {
        public abstract void Travel();
        public void Places() { Console.WriteLine("Visiting: Vienna, Salzburg"); }
        public void Activities() { Console.WriteLine("Skiing, Walking, Fishing"); }
    }

    public class HolidayWithTravel : Holiday
    {
        public override void Travel() { Console.WriteLine("By train eurostar, then by car"); }
    }
    sealed class Security { }
    public static class AddingToStrings
    {
        public static string AmazingExtraStringMethod(this string s)

        {
            Console.WriteLine("Changing string");
            s = s + " ---> add your comment";
            return s;
        }

    }

}
