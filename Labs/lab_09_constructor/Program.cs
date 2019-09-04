using System;

namespace lab_09_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var merc01 = new Mercedez("CHASIS123ABC", "silver", 2500); // calling the default constructor, but we can define it
            var merc02 = new Mercedez();
            var AClass = new AClass("Chassis0000", "blue", 2750);

            var a104 = new A104("Chassis1111", "red", 1875);

            var a104c02 = new A104("Chassis1111", "red");
        }
    }
    class Mercedez
    {
        protected string _engineChassicID; // changed private to protected for it to ba available in child classes
        public string Color { get; set; }
        public int Length { get; set; }
        public Mercedez() { }          // BLACK DEFAULT ONE : EXPLICITLY CODE IT
        public Mercedez(string engineChassisID, string color, int length)
        {
            this._engineChassicID = engineChassisID;
            this.Color = color;
            this.Length = length;

        }
        

    }
    class AClass : Mercedez
    {
        public AClass() { }
        public AClass(string engineChassisID, string color, int length) // constructed explicitly
        {
            this.Length = length;
            this.Color = color;
            this._engineChassicID = engineChassisID;
        }
    }
    class A104 : AClass
    {
        //different constructor : calling BASE (PARENT) constructor
        // : base() calling base method from parent class
        public A104(string engineChassisID, string color, int length = 2300) : base(engineChassisID, color, length) { } 
    }
}
