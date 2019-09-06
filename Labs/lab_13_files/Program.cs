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
