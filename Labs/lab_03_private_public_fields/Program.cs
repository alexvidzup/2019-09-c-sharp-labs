using System;

namespace lab_03_private_public_fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var person01 = new Person();
            person01.Name = "Fantasia";
            //person01.NINo = "ABC123";

            Console.WriteLine("Enter youre NINo");
            person01.SetNINo(Console.ReadLine());
            // print NINo
            string output = person01.GetNINo();
            Console.WriteLine("Here's your NIN0");
            Console.WriteLine(output);

            var person02 = new Person();
            person02.Name = "Bob";
            person02.SetNINo("123ab123");


            var rabbit = new Rabbit();
            rabbit.Name = "Cute01";
            // rabbit._bloodtype ... INVALID
            rabbit.Age = -10;
            Console.WriteLine(rabbit.Age);
        }
    }
    class Person
    {
        private string NINo;
        public string Name;

        // Getter / Setter Methods to read/write private data
        public string GetNINo()
        {
            return this.NINo;
        }
        // Parameter is data passed into the method
        public void SetNINo(string nino)
        {
            this.NINo = nino;
        }
    }
    class Rabbit
    {
        private int _bloodType;             // FIELD
        private int _age;
        public string Name { get; set; }    // AUTO-IMPLEMENTED PROPERTY 


        // A longer way to write out { get; set; }
        public int Age
        {
            get {
                return this._age;
            }
            set {
                if (value > 0)
                {
                    this._age = value; // value is c# code word
                }
            }
        }
    }
}
