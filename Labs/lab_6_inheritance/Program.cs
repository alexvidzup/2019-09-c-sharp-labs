using System;

namespace lab_6_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog();
            d.Name = "Fido";
            var labrador01 = new Labrador();
            labrador01.Name = "MansBestFriend";
            Console.WriteLine(labrador01.Name);
        }
    }
    class Dog
    {
        public string Name { get; set; }
    }
    class Labrador : Dog { }

}
