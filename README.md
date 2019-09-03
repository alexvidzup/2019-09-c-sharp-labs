# Into to C# and .NET

## History of coding

Operating System ==> makes a bit of hardware (motherboard, processor, RAM, network car) 'work'

	Common operating systems we know have been written originally in 'C'

	UNIX (original)			PAID, CLOSED SOURCE
	APPLE IOS and OSX		UNIX DERIVATIVE, CLOSED SOURCE
	WINDOWS					CLOSED
	LINUX 					OPEN SOURCE

		OPEN SOURCE WINS!!!
			WINDOWS ==> .NET is now OPEN SOURCE !!!

			LINUX ==> World's top 500 supercomputers 
				TFlop/s Tera (10^12)  floatring point operations/sec
					1,000,000,000,000


		Programming Language
				'C'
				then
				C++ => in use today
					'raw' coding ==> C++
				However!
					Java - run in 'JVM' Virtual Machine (install Java)
					C# Microsoft 'push' people to use this language
						F# Functional programming language
					Python
						Engineering
						Data Science

		Cloud
			Traditional computing ran on local hardware

			Today everything has changed

				Traditional : local
				Newer 		: services to cloud
						1) AWS Amazon			No 1 provider 70%?
						2) Azure				25% market		*** Microsoft : MOST REVENUE IN THIS SPACE
						3) Google cloud 		5%

				Container : Mini virtual machine : run individual 'apps'

					Group of containers : manage with 'Kubernetes' from Google (now open source)

				Function as a service ==> individual methods : call in cloud !!!

		Structure of an application

			.NET old, huge, cumulative libraries for ALL WINDOWS!

			.NET Core 	new, streamlined version: valid LINUX, MAC

			.sln XML file with ALL NAMES OF ALL PROJECTS INSIDE

				'Container' which has no function of itself ==> just to hold multiple prjects

			.csproj

				METADATA for individual project

			Program.cs

				class Program {
					public static void Main(){

						// RUN CODE HERE
					}

				}

		.NET structure
			in order to build a program with C# / .NET we need the following

			CLI - Common Language Infrastructure : RULES FOR THE LANGUAGE

			CLR - Common Language Runtime 		 : Run Inside this environment

				Garbage Collector 				 : Reclaim memory when we are finished with an object

			CSC C# Compiler						 : Turn .cs text into .exe BINARY RUNTIME EXECUTABLE FILE

			CIL Common Intermediate Language 	 : Half-compiled code 'assembly language'

					CS ==> CIL (half-way-house) ==> CLR runtime
				 raw code
					
						Tool 'ILDASM' ==> inspect .exe and view this 'CIL' compiled code


			# OOP Object Oriented Programming

			Traditional computing has been LINEAR PROGRAMMING where code starts at line 1 and runs to the end

				OK but when GUI was invented, screen object appeared
					Button ==> CLick (event) ==> Method (function)  (even 'habnder')

					OBJECT 			EVENT 			METHOD (CODE)

					Object looks like
					{
						id:1						field: value (key/value pairs)
						name:"bob"
						dob:"10/10/1992"
						likes: ["strawberries","pizza"]

					}

					Array [1,2,3]

					String "some text"

					Number
						Whole number 	integer
						Decimal			float (32 bits long) / double (64 bits long) / decimal type (128 bits)

						Char 'f'

				# Creating Basic Objects

				Class = Template = Blueprint for creating object
```cs
				class Mammal {
				int heigth;
				int weight;
				int length;
				string type;
				}

				var m01 = new Mammal();
				m01.height = 400;
```


 # Method

 Method = Function
 	Call a Method to get something done
 		Let's GROW OUR DOG 
```cs
 			Grow()
 			{
 				Age = Age + 1;
 				Height = Heigth + 10;
 			}
```

	# Private and Public fields
```cs
	class person
	{
		private string NINo;
		public string name;
	}
```


# Fields and PRoperties

	In a class we can have

		fields - tend to be private 	 private string NINo;

		- convention camelCase 			private string privateData;

		- convention _camelCase 		private string _privateData;

	properties - tend to be PUBLIC 		public string name {get;set;}

			- convention PascalCase 	public string ThisIsAPublicProperty

			- {get;set:} // abbreviations for GET/SET methods which we coded


Code done so far:
```cs
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
```
# Creating Multiple Objects

Array written [1,2,3] has FIXED SIZE

List written List<int>() has VARIABLW SIZE and we can use this to ADD items to a list

		// create a lab

		// count from 1 to 10

		// create Rabbits

		// name = "Rabbit" + 0 + i 	Rabbit01, Rabbit02, Rabbit03
		// age = i 
		// add to list of rabbits
		// print out list at end





```cs

using System;
using System.Collections.Generic; //list

namespace lab_5_rabbits
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Rabbit> rabbits = new List<Rabbit>();
            
            // count from 1 to 10
            for (int n = 1; n <= 20; n++)
            {

                var r = new Rabbit();
                r.Age = n;
                if (n < 10)
                {
                    r.Name = "Rabbit" + 0 + n;
                }
                else
                {
                    r.Name = $"Rabbit{n}";
                }



                rabbits.Add(r);

            }
            foreach (Rabbit r in rabbits) 
            {
                Console.WriteLine($"Rabbit is {r.Age} years old and it's name is {r.Name}");
            }

            // create Rabbits

            // name = "Rabbit" + 0 + i 	Rabbit01, Rabbit02, Rabbit03
            // age = i 
            // add to list of rabbits
            // print out list at end
            Console.ReadLine();
        }
    }
    public class Rabbit
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
```
		



# Random
	select text and comment it with = ctrl + K + C
					uncomment with = ctrl + K + U



# Inheritance
	dog - labrador


# Methods in more Detail
	convention name is PascalCase 		void DoThis(){}
	parameters passed in 				void DoThis(){int x, string y}
	return 		passed out 				string DoThis (){return "hi";}
	optional 	passed in 				void DoThis (int x = 1000) {}
											pass in x but if missing set value to 1000

	out parameters pass OUT 			void DoThis(int x, int y, out int z);

	Tuple is a fancy new variable from C#

	(int x, string y, bool z) 	is now a custom data type!


Notes from lab 07 methods and tuple etc.
```cs
using System;

namespace lab_07_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThisEveryday();
            // method INSIDE method
            DoThisAswell();
            var m = new Mammal();
            m.GetOlder(); // increase age by 1
            void DoThisEveryday()
            {
                Console.WriteLine("I am doing this");

            }

            CountNum(5000); // y only
            CountNum(5000, 300);


            OutParameters(10, 10, out int a);
            Console.WriteLine($"output: {a}");

            TupleMethod();   // not gathering the output
            var tupleOutput = TupleMethod(); // OUTPUT sent to custom object
            Console.WriteLine($"tupleOutputs are {tupleOutput.x}, {tupleOutput.y}, {tupleOutput.z}");
            
        }
        static void DoThisAswell()
        {
            Console.WriteLine("I am doing something too!");
        }
        static void CountNum (int y, int x = 100)
        {
            Console.WriteLine(x * y);
        }

        static void OutParameters (int x, int y, out int z)
        {
            z = x * y; // Will return this as z
        }

        static (int x, string y, bool z) TupleMethod()
        {
            return (10, "hi", false);
        }
    }
    class Mammal
    {
        public int Age { get; set; }
        //Instance method
        public void GetOlder() { Age++; }
    }
}
```




				
