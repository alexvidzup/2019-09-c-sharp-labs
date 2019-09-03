using System;

namespace lab_02_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // use the class: create new Dog object ==> call this an INSTANCE (of a class)
            var dog01 = new Dog(); // create new empty blank dog object
            dog01.Name = "Fido";
            dog01.Age = 1;
            dog01.Height = 400;
            // Grow out dog
            dog01.Grow();
            //Print new age and heigth
            Console.WriteLine($"Your {dog01.Name} age is: {dog01.Age} and heigth is {dog01.Height}");
        }
    }



    // INSTRUCTION (BLUEPRINT) FOR CREATING NEW DOG OBJECT
    class Dog
    {
        public string Name;
        public int Age;
        public int Height;


        public void Grow() // have the method but return nothing
        {
            // Let computer now: is it returning any value????
            // NO ==> use VOID
            // YES ==> SPECIFY TYPE eg. int, string, bool, double, decimal
            this.Age++;
            this.Height += 10;
        }
    }
}
