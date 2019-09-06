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
