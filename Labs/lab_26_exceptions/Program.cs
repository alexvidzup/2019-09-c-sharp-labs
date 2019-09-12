using System;
using System.IO;

namespace lab_26_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ERROR : bank calculater interest incorrectly : programmer error in logic
            // EXCEPTION : 
            // code crashes so program cannot continue

            // handled      exception takes place inside a TRY BLOCK 
            //              code is handled in CATCH BLOCK
            //              whether exception or not, then run FINALLY block
            // unhandled    compiler won't compile, code crashes - messy exception - program terminates uncleanly
            // compiler     RED LINE ie will not build
            // runtime      eg divide by zero
            int x = 10;
            int y = 0;

           // Console.WriteLine(x/y); UNHANDLED EXCEPTION cannot divide by 0 (zero)
            try
            {
                // any code that migth produce an exception
                Console.WriteLine(x / y); // THROW AN EXCEPTION
            }
            catch (Exception e)
            {
                Console.WriteLine("Hey don't do that");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("have fun");
            }

            // custom exceptions
            var myException = new Exception("Hey this is a Alex Special");
            try {
                // Imagine engine is GETTING HOT but has NOT BURNT OUT yet
                throw (myException);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // finally block is optional

            // LARGE APPLICATION
            //NESTING : MAIN, SUB, SUB.
            try
            {
                try
                {
                    try
                    {
                        throw (new Exception("Inner Exception - Phil's code"));
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                }
                catch (Exception e) { throw; }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                File.WriteAllText("log.txt", $"Phil's code not working again - typical - {e.Message}");
            }

            // types of exceptions

            try { Console.WriteLine(x/y); }
            catch (DivideByZeroException e) {
                Console.WriteLine("Don't do that");
            }
            catch (Exception e) {
                Console.WriteLine("All exceptions");
            }

        }
    }
}
