using System;
using System.Collections.Generic;

namespace lab_15_abstract_class_own_version
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var r = new SweetPotato();
            r.Color(); // prints different colour
            r.Shape();
            r.Taste();
            var n = new NormalPotato();
            n.Color(); // print different colour
            n.Shape();
            n.Taste();

            
            }

           
        }
    }

    abstract class PotatoFamily
    {
        public abstract void Color();

        public void Shape() { Console.WriteLine("Shape is Oval"); }

        public void Taste() { Console.WriteLine("Taste is nice!"); }

    }

    class SweetPotato : PotatoFamily
    {
        public override void Color() { Console.WriteLine("Colour is orange!"); }
    }
    class NormalPotato : PotatoFamily
    {
        public override void Color() { Console.WriteLine("Colour is yellow!"); }
    }




