using System;
//using System.Collections.Generic

namespace lab_04_class_summary
{
    class Program
    {
        static void Main(string[] args)
        {
            //static list<User> users = new List<User>();
            //Keep the app running constant
            while (true)
            {    //Ask user whether they want to create new
                Console.Write("To create new user user 'N' \n To view user database predd D ");
                string create = Console.ReadLine();
                if (create == "n" || create == "N")
                {
                    var p = new User();
                    //Ask user for their name
                    Console.Write("Enter users name: ");
                    p.Name = Console.ReadLine();
                    //Ask user for their age
                    Console.Write("Enter user age: ");
                    p.Age = Console.ReadLine();
                    //Ask user for their DOB
                    Console.Write("Enter user DOB: ");
                    p.SetDOB(Console.ReadLine());
                    //Ask user for their Password
                    Console.Write("Enter your password: ");
                    p.SetPassword(Console.ReadLine());
                }
                //Create instance
                
                


                // console.readline(); to input data from the user
            }
        }
        //Create class with private/public field & get;set;

    }

    // New class with public and private fields
    class User
    {
        public string Name;
        public string Age;
        private string dob;
        private string password;



        // Function to set DOB
        public string GetDOB()
        {
            return this.dob;
        }
        
        // Function to retrieve DOB
        public void SetDOB(string dob)
        {
            this.dob = dob;
        }

        public string GetPassword()
        {
            return this.password;
        }


        public void SetPassword(string pass)
        {
            this.password = pass;
        }

    }
}
