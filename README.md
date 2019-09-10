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


# Naming

camelCaseLikeThis   private field

PascalCaseLikeThis: 1) Methods (Verb eg DoTHis())
                    2) Calss names (Noun)
                    3) Properties public string Name {get;set;} Name is PascalCase

    _privateField   underscore prefix clearly tell everyone it's private

    SQL_column_name_like_this_snake_case     snake_case

    File names and Folder names and Paths to folder

    C:\Parent\Child\file1.txt   Path

        Avoid spaces always (if you can)

        "String with spaces always enclosed in quotes"

html-web-page-always-write-like-this-kebab-case.html
    %20 means someone put space  (" ") in html page

# Constructor 

    Class MyClass {
    private string _NINo
    public string Myname {get; set;}
    public string DateOfBirth {get;set;}
    }

    // instantiate 
    var myclass = new MyClass();     new keyword : invoking (calling) a special method
                                     called the CONSTRUCTOR METHOD
                                     CONSTRUCTOR: used when constructing a new object

```cs
using System;

namespace lab_09_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var merc01 = new Mercedez("CHASIS123ABC", "silver", 2500); // calling the default constructor, but we can define it
            var merc02 = new Mercedez();
        }
    }
    class Mercedez
    {
        private string _engineChassicID;
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

    }
    class A104 : AClass
    {

    }
}

```

Constructors are NOT INHERITED so child constructors need to be explicitly coded

change private to protected for child classes to be able to classes class parameters

see changed code
```cs
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
```

    ## Constructor Summary

    Constructors just help us create new INSTANCES with MINIMUM OF HARD WORK
    They are NOT INHERITED
    Default one is BLANK and is present initially. Must add it in if we create our own constructor
    and still want the default one present.



# Overloading

Method01(){}

Method01(int x){}

Method01(int x, string y){}

Method01(int x, string y, bool z){}

```cs

using System;

namespace lab_10_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Method01();
            Method01(5);
            Method01(10, "hello!");
            Method01(25, "Hey There!", true);

            Console.Read();
        }
        static void Method01() { Console.WriteLine("blank"); }

        static void Method01(int x) { Console.WriteLine(x); }

        static void Method01(int x, string y) { Console.WriteLine($"{x} {y}"); }

        static void Method01(int x, string y, bool z) { Console.WriteLine($"{x} {y} {z}"); }
    }
}
```


# Polymorphism

(little outro)
    Interviews : favourite question
        What are the 4 pillars of OOP?
            1. Inheritance      Parent => Child         class Child : Parent{}
            2. Escapsu;atopm    private keyword to hige NINo data / engineChassisID
            3. Abstraction Public Getter/ Setter methods to access and manipulate private data
            Picture:

                Driver                Accelerator           Encapsulated
                                       Pedal                Combustion Engine

                    Driver is 'abstracted' away from engine by middle layer
                                (accelerator pedal)

                instance            public get/set          private field
                                      property

            4. Polymorphism

                Picture : Family

                    Parents : virtual HaveAParty(){ // INVITE FRIENDS : DINNER PARTY}
                            virtual == > means can override this idea if you want (optional)

                    Child5yrs : override HaveAParty (){ // bouncy castle}
                            override ==> child can optionally replace method with own version

                    Child10yrs : HaveAParty(){ // play lego}

                    Child18yrs : HaveAPArty () {  // Evening out}

        Minor side note : two keywords with similiar user here
                a) override
                b) new 

Example of override and new

```cs
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
```


#To do lab - rabbits explosion
## make rabbits that take time to grow population
Class Rabbit{
    string Name;
    int Age;
}

List<Rabbit> rabbits

Thread.Sleep(200); 1/5 sec

Loop

Every loop, create new rabbit and add to list of rabbits

Set population limit and see how many iterations it takes to reach population limit.

This will be version 1 and will be a LINEAR RELATIONSHIP eg 50 iteration to reach population of 50

Done:
```cs
using System;
using System.Collections.Generic;
using System.Threading;

namespace just_do_it_lab_11_rabbit_explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = 0;
            List<Rabbit> rList = new List<Rabbit>();

            while (population <= 50)
            {
                var rab1 = new Rabbit();

                Thread.Sleep(200);
                rList.Add(rab1);
                Console.WriteLine($"Created rabbit number {population}");
                population++;
                

            }
        }
    }
    class Rabbit
    {
        string Name;
        int Age;
    }
}
```

#Update to the task

    Real world rabbits increase exponentially
    Every iteration, every rabbit which already exists can spawn another one

    Set a new population limit and see how many iterations it takes to reach the new limit in the natural world

    


# Working with files
## Logging, creating new text files, reading data from text files

```cs
using System;
using System.IO; // using system Inpit and Output
using System.Linq; 


namespace lab_13_files
{
    class Program
    {
        static void Main(string[] args)
        {

            if (File.Exists("myFile.txt"))
            {
                var string1 = File.ReadAllText("myFile.txt"); // Reads text info from a file
                Console.WriteLine(string1);
            }

            File.WriteAllText("output.txt", "some data"); // overrides data

            Console.WriteLine("\nSavemultiple lines\n\n");

            File.WriteAllText("multiplelines", "some\ndata\non\ndifferent\nlines"); // creates file with multiple lines 
            Console.WriteLine(File.ReadAllText("multiplelines.txt")); // works in windows

            Console.WriteLine("===Saving arrays to multiple lines");

            string[] myArray = new string[] { "some", "data", "in", "multiple", "lines" };
            File.WriteAllLines("multiLineFile.txt", myArray);
            //read it back
            var outputArray = File.ReadAllLines("multiLineFile.txt");
            // print array using fancy Lambda syntax
            Array.ForEach(outputArray, item => Console.WriteLine(item));

            File.WriteAllText("multiplelines1.txt", "some" + Environment.NewLine + "text" + Environment.NewLine + "here"); // A proper way to create new line in tyext

            Console.WriteLine("\n=== Logging ===\n");

            var d = DateTime.Now;
            Console.WriteLine(d);

            for (int i = 0; i < 10; i++)
            {
                File.AppendAllText("myLogFile.log", $"Event happened at: {DateTime.Now}" + Environment.NewLine);
                System.Threading.Thread.Sleep(300);

            }
            Console.WriteLine(File.ReadAllText("myLogFIle.log"));
        }
    }
}
```


## Keeping the time (diagnostics)
```cs
using System;
using System.Diagnostics;
using System.IO;

namespace lab_14_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();


            var counter = 0;
            //while (true)
            //{
                for (int i = 0; i < 100_000_000; i++) ;
                {
                    counter++;
                }

                //var b = 0b_1010_1010_1010;
                //var hex = 0x;

                s.Stop();
                Console.WriteLine(s.Elapsed);
                Console.WriteLine(s.ElapsedMilliseconds);
                Console.WriteLine(s.ElapsedTicks);
            //}

            // Tried to create infinite number of files
            //for (int n = 0; n < 50; n++)
            //{
            //    var path = $"C:\\CreateTest {DateTime.Now.ToString()_{i}}.txt";

            //    File.AppendAllText(path, "some text");
          

        }
    }
}
```


## Attempting to create a lot (or infinite) files

```cs
            // Tried to create infinite number of files
            for (int n = 0; n < 50; n++)
            {
                var path = $"C:\\CreateTest {DateTime.Now.ToString()_{i}}.txt";

                File.AppendAllText(path, "some text");
```



# Rabbit Tests

ENTER STUFF ABOUT RABBIT TESTS HERE


# OOP Continued

# Abstract Classes

So far we have
    Class MErcedes {                    class is BLUEPRINT / TEMPLATE for new objects

    private int `_privateField`;        field (private, encapsulated)

    public string Name {get;set}        property (Public, provides the abstraction layer in OOP 4 pillars)

    public void DoThis(){}              method: Verb : Action code

    public Mercedes(){}                 constructor : same name as class (and no return type)
        }

    var instance = new Mercedes();      instance = new object FROM CLASS

    A normal class is called a 'CONCRETE' class because we can create REAL OBJECTS (real instances) from it

## Mind picture for Abstract Classes

    Think about a holoiday in planning

        Class Holoiday {
            public void TravelPlans(){}
            public void PlacesToVisit() {cw("This list is now complete");}
            public void Activities()    {cw("All activities planned out");}
        }                               |---- CODE IMPLEMENTATION --------|

        One method has NO CODE IMPLEMENTATION (NO CODE 'BODY')

            THis methos is 'ABSTRACT' because it exists but has no code implementation

                public abstract void TravelPlans(); // ADD abstract keyword and remove {} (curly braces)

        Soluction is to derive a SUB-CLASS  and INHERIT  from ABSTRACT class

        PARENT : ABSTRACT   public void TravelPlans();

        CHILD :             public override void TravelPlans(){//with the body code present}

From visual studio:
```cs
using System;

namespace lab_15_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //var h = new Holiday();
            var h = new HolidayWithTravel();
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
}
```



# Sealed class

When dealing with security, it might not be a good idea that people can inherit from a secure 
class but then introduce vulnerabilities

Think car engine: seal inside secure chassic so amateurs don't mess up the engine and cause accidents

Think CPU : discourage overlocking

sealed class Security {
    
}
// cannot inherit from thiss

# Extending A Sealed Class

string is a sealed class with lots of methods like this one

```cs
            string x = "Hello World";
            if (x.StartsWith("hello"))
            {
                Console.WriteLine("World");

            }
```
Imagine we want our own custom string method

Let's build one
```cs
public static class AddingToStrings{
    pub;ic static void AmazingExtraStringMethod(this string s){
        s = s +" ---> add your comment";
    }
}
```

Built working method here:
```cs
 public static class AddingToStrings
    {
        public static string AmazingExtraStringMethod(this string s)

        {
            Console.WriteLine("Changing string");
            s = s + " ---> add your comment";
            return s;
        }

    }
``` 
And to call it:
```cs
            x = x.AmazingExtraStringMethod();
            Console.WriteLine(x);
```


# WPF application

With this course we are going to have 3 areas of leaning
    CONSOLE : Most of the learning here! !!!core work!!!

    WPF     : SCREEN which can place objects eg : crude app
                    Goal is to create:  1) Business Interface
                                        2) Canvas : Simple images for game (crude)
                                            (Windows forms were before WPF) 
    WEBSITES: Focus on business style aplication
                Function Data etc.
                    A) ASP regular website
                    B) MVC Website

WPF Windows Presentation Foundation:
    
        xml skeleton for GUI
        C# code behind
                        XML is a text while into which we can put meaningful, structured data
                            (XML = Extensible Markup Language)
                            <root>
                                <row1>
                                    <col> data <col>
                                        <col attribute="data-also-can-be-here"> more data</col>
                                </row1>

                            </root>
        Microsoft LOVE XML
        Everyone else loves JSON

        ## Changing colours in xml
```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace lab_16_wpf_rabbit_explosion_graphic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            Button01.Content = "Click here";
            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += changeColor;
        }
        static int counter = 0;
        //private void Button01_Click(object sender, RoutedEventArgs e)
        //{

        //    counter++;
        //    Button01.Content = $" you've clicked {counter} times";

        //    // random color generator
            

        //    //Create "Alex"

            



            
        //}
        public void changeColor(object sender, EventArgs e)
        {
            
            Label01.Background = RandomColorGenerator();
            Label02.Background = RandomColorGenerator();
            Label03.Background = RandomColorGenerator();
            Label04.Background = RandomColorGenerator();
            Label05.Background = RandomColorGenerator();
            Label06.Background = RandomColorGenerator();
            Label07.Background = RandomColorGenerator();
            Label08.Background = RandomColorGenerator();
           


            //Label00.Background = new SolidColorBrush(Color.FromRgb(color1, color2, color3));
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {

            timer.Start();
        }
        
        public SolidColorBrush RandomColorGenerator()
        {
            var r = new Random();
            var randomColor = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
            return randomColor;
            
        }

    }
}
```

Last code for XML file:
```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace lab_16_wpf_rabbit_explosion_graphic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            Button01.Content = "Click here";
            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += changeColor;
        }
        static int counter = 0;
        //private void Button01_Click(object sender, RoutedEventArgs e)
        //{

        //    counter++;
        //    Button01.Content = $" you've clicked {counter} times";

        //    // random color generator
            

        //    //Create "Alex"

            



            
        //}
        public void changeColor(object sender, EventArgs e)
        {
            var r = new Random();
            Label01.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label02.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label03.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label04.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label05.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label06.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label07.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Label08.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label
            Button01.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256))); // top middle label

            

            
            //Label00.Background = new SolidColorBrush(Color.FromRgb(color1, color2, color3));
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {

            timer.Start();
        }

        public (byte c1, byte c2, byte c3, byte c4, byte c5, byte c6) RandomColorGenerator()
        {
            var r = new Random();
            byte c1 = (byte)r.Next(0, 256);
            byte c2 = (byte)r.Next(0, 256);
            byte c3 = (byte)r.Next(0, 256);

            byte c4 = (byte)r.Next(0, 256);
            byte c5 = (byte)r.Next(0, 256);
            byte c6 = (byte)r.Next(0, 256);

            byte c7 = (byte)r.Next(0, 256);
            byte c8 = (byte)r.Next(0, 256);
            byte c9 = (byte)r.Next(0, 256);
            return (c1, c2, c3,c4,c5,c6);
            
        }

    }
}
```

# WELL WORKING EXPONENTIAL RABBITS
```cs
using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace just_do_it_lab11_rabbit_explostion_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeCounter = new Stopwatch();
            timeCounter.Start();
            int populationLimit = 850;
            int projectedPopulation = 1;
            List<Rabbit> rabbitList = new List<Rabbit>(); // Created new rabbit list

            var rabbitN1 = new Rabbit(); // created new rabbit

            rabbitList.Add(rabbitN1); // added rabbit to the list

            Console.WriteLine($"At the moment we have {rabbitList.Count} rabbit(s)");

            while (projectedPopulation < populationLimit)
            {
                int populationBeforeReplication = projectedPopulation;
                
                foreach (Rabbit r in rabbitList)
                {
                    projectedPopulation++;
                }
                //Console.WriteLine($"projected population:{projectedPopulation}");

                while (rabbitList.Count < projectedPopulation)
                {
                    rabbitList.Add(rabbitN1);
                    if (rabbitList.Count >= populationLimit) { break; }
                }
                int difference = rabbitList.Count - populationBeforeReplication;
                Console.WriteLine($"projected population:{projectedPopulation},made {difference} rabbits this round, current rabbit population: {rabbitList.Count}");
                Thread.Sleep(200);
                
            }
            timeCounter.Stop();
            Console.WriteLine($"The number of rabbits has reached its population limit ({populationLimit})\nIt took {timeCounter.ElapsedMilliseconds} milliseconds");

        }
    }
    class Rabbit
    {
        string Name;
        int Age;
    }
}
```


# Static

class MyClass{
    private int _hideMe; // private field (encapsulation)

    public string Name {get;set;} //public PROPERTY (OOP Abstraction)

    public void DoThis() {}
}

abstract Class Idea{
    abstract void DoThis(); // no implementation, no code BODY
}

class SolidThoughts : Idea{
    override void DoThis(){}
}

ABSTRACT CLASS ==> cannot instantiate
CONCRETE (REGULAR) CLASS => can instantiate

    var m = new MyClass();

OOP Polymorphysm == when you have a method in a class (parent) and you can override it in the child class
                    Parent  : virtual (not empty, has a code body)
                    Child   : override (optional)
OOP Abstraction
                    Parent  : abstract (empty)
                    Child   : override (mandatory)
OOP Inheritance 

Access Modifiers public, private, protected, internal
        public      : see from anywhere
        private     : hidden inside class
        protected   : hidden inside class and derived child classes
        internal    : within compiled .exe / DLL => visible in this scope

            library MYLIBRARY.DLL
                internal : user within this DLL but not outside it

Static
    
    class MyClass{
        private int _hidden;                    INSTANCE
        public string Property01 {get;set}      INSTANCE
        public void Method01(){}                INSTANCE

        public MyClass(){} // constructor, don't need to code one unless specify parameters
    }

    var m = new MyClass(); // constructor
    m = instance
        m.Property01;
        m.Method01();


    Math.PI;
    Math.Random()
    Math.Round()
                    STATIC MEMBERS ATTACHED DIRECTLY TO MATH CLASS

        class MyClass{
            static public int Property01{get;set;}      CLASS / STATIC
            static public void DoThis(){}               CLASS / STATIC

        }

        MyClass.Property01;
        MyClass.DoThis();
                            don't change with relation to instances

    Mind picture
        user (instance) with PERSONAL SHOPPING BASKET
        static count of TOTAL ITEMS IN STOCK

            user1 with instance1
            user2 with instance2
            ...
            user100 with instance100

            static MEMORY AVAILABLE


# SQL == Structured Query Language
            Microsoft               MS - SQL (MSSQL)(paid product)
            free                    MY - SQL (MYSQL)

    Relational Database
        Tables
            ID
            Fields

        User
            UserId;
            UserName;

        Category
            CategoryID;
            CategoryNAme;

        We can create RELATIONSHIPS 

        User
            UserId;
            UserName;
            CategoryId;     FOREIGN KEY (Id in another table)

        Id 'IDENTITY' ==> Unique, Auto-Increment To Highest Value

Proposal today
    SQL : Create database with rabbit tables
    Entity : C# ==> hook into this database
                    View, Update Rabbits

SQL commands

    View => server explorer, data connection, add (choose  microsoft SQL server)
            
            =========== (localdb)\mssqllocaldb =================


            

    View => SQL Object Explorer MSSQL LOCAL DB SQL SERVER ETC ETC

        Gives access to the local computer using SQL server 

            Files called ...mdf (Microsoft Database File)

            Stored in C:\Users\<username>\   folder

Query done in class

```sql
use master
go

drop database if exists RabbitDb
go


create database RabbitDb
go



use RabbitDb
go

CREATE TABLE Rabbits(
    RabbitId INT NOT NULL IDENTITY PRIMARY KEY,
    AGE INT,
    Name VARCHAR(50) NULL
);


INSERT INTO Rabbits VALUES ('1','Rabbit01')
INSERT INTO Rabbits VALUES ('0','Rabbit02')
INSERT INTO Rabbits VALUES ('2','Rabbit03')

select 'Rabbit Database'

select * from Rabbits -- select all from Rabbits table
```

# Connecting to a database

    Microsoft can connect directly to the databse using Entity Framework

    EF6 : Framework
    EFCore: Lighter, more open source

    If we begin using EF6 there is more support so it's easier to get going

    New Console App (framework)
    Add Entity
    Connect to database
    View rabbits


## Homework

New WPF Just_Do_It_12_Rabbit_explosion using .NET Framework
Add 2 text boxes and an ADD button
Add Entity
When you click the ADD button
    ADD A NEW RABBIT
    DISPLAY A RABBIT PICTURE FOR ONE SECOND

Create a TEXTBLOCK and do a foreach loop to output the rabbit data into this text block

Idead? Add timer and start adding own random rabbits

				
