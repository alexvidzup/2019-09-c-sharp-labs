using System;

namespace lab_11_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var p01 = new Parent(20, "Garry");

                Console.WriteLine($"{p01.Name} is now {p01.Age}");

                Console.WriteLine("How much older does Garry get?");

                p01.GrowOlder(Int32.Parse(Console.ReadLine()));

                Console.WriteLine($"{p01.Name} is now {p01.Age}\n");

                var c01 = new Child(2, "Sally");

                Console.WriteLine($"{c01.Name} is now {c01.Age}");

                Console.WriteLine("How much older does Sally get?");

                c01.GrowOlder(Int32.Parse(Console.ReadLine()));

                Console.WriteLine($"{c01.Name} is now {c01.Age}\n");
            }
        }
    }
    // create base class (parent)

    // create child class

    //add 2 field

    //add constructor

    //parent add method (change number)
    class Parent
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Parent() { }
        public Parent(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public virtual void GrowOlder(int addYears) { this.Age += addYears; }

    }
    class Child : Parent
    {
        // COPY THE CONSTRUCTOR FROM THE PARENT CLASS
        //public Child() { }
        //public Child(int age, string name)
        //{
        //    this.Age = age;
        //    this.Name = name;
        //}
        public Child(int age, string name) : base(age, name) { } // 
        public override void GrowOlder(int addYears) {
            this.Age += addYears * 2;
            base.GrowOlder(3);
        }
    }
    
    

}
