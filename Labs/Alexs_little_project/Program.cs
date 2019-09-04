using System;
using System.Collections.Generic;
using System.Linq;


namespace lab_04_class_summary

{
    class Program
    {
        static void Main(string[] args)
        {


            // Create list for the new users
            List<User> users = new List<User>();
            //Creating couple users straight away

            //Set user ID as number 
            var r = new Random();

            //Create "Alex"
            var userX = new User();
            userX.ID = r.Next(100, 999);
            userX.Name = "Alex"; //name
            //user1.Age = Console.ReadLine(); //Age
            //user1.Email = Console.ReadLine(); //email
            userX.SetDOB("09-09-1980"); //DOB
            //user1.SetPassword(Console.ReadLine()); //Password
            users.Add(userX);

            //Create "John"
            var userY = new User();
            userY.ID = r.Next(100, 999);
            userY.Name = "John"; //name
            //user1.Age = Console.ReadLine(); //Age
            //user1.Email = Console.ReadLine(); //email
            userY.SetDOB("02-12-1985"); //DOB
            //user1.SetPassword(Console.ReadLine()); //Password
            users.Add(userY);

            //Create "George"
            var userZ = new User();
            userZ.ID = r.Next(100, 999);
            userZ.Name = "George"; //name
            //user1.Age = Console.ReadLine(); //Age
            //user1.Email = Console.ReadLine(); //email
            userZ.SetDOB("01-01-1992"); //DOB
            //user1.SetPassword(Console.ReadLine()); //Password
            users.Add(userZ);




            while (true) //Keep the app running constant
            {    //Ask user whether they want to create new
                Console.Write("To create new user user 'U' \nTo view user database press 'D' ");
                string input1 = Console.ReadLine();

                //Create new user and get data function
                if (input1 == "u" || input1 == "U")
                {

                    var user1 = new User();
                    //Set user ID as number 

                    user1.ID = r.Next(100, 999);
                    //Ask user for their name
                    Console.Write("Enter users name: ");
                    user1.Name = Console.ReadLine();
                    ////Ask user for their age
                    //Console.Write("Enter user age: ");
                    //user1.Age = Console.ReadLine();
                    ////Ask user for their email
                    //Console.WriteLine("Enter your email");
                    //user1.Email = Console.ReadLine();
                    //Ask user for their DOB
                    Console.Write("Enter user DOB: ");
                    user1.SetDOB(Console.ReadLine());
                    ////Ask user for their Password
                    //Console.Write("Enter your password: ");
                    //user1.SetPassword(Console.ReadLine());
                    users.Add(user1);

                }

                else if (input1 == "D" || input1 == "d")
                {
                    Console.WriteLine("Welcome to user database!\n Here is a list of users on the database:");
                    foreach (var x in users)
                    {
                        Console.WriteLine($"User ID: {x.ID}, Name: {x.Name}"); //Age: {user1.Age}, email: {user1.Email}.");
                    }

                    Console.Write("Would you like to view private user data? (Y/N) ");
                    string privateDataView = Console.ReadLine();

                    if (privateDataView == "Y" || privateDataView == "y")
                    {
                        Console.WriteLine("To view private information about users enter their user ID; ");

                        bool idEntry = Int32.TryParse(Console.ReadLine(), out int userID);
                        if (idEntry == false)
                        {
                            Console.WriteLine("Please enter 3 digit ID to retrieve hidden data");
                        }
                        else
                        {
                            // User userMatch = users.Where(u => u.ID == userID).FirstOrDefault();

                            var userMatch =
                                (from x in users
                                 where x.ID == userID
                                 select x).FirstOrDefault();


                            Console.WriteLine($"Users {userMatch.ID} DOB is: {userMatch.GetDOB()}.");
                        }
                        Console.WriteLine("Would you like to continue? (Y/N) ");
                        privateDataView = Console.ReadLine();
                    }
                    else { }





                }






                // console.readline(); to input data from the user
            }
        }




    }

    // New class with public and private fields
    //Create class with private/public field & get;set;
    class User
    {
        public int ID;
        public string Name;
        public string Age;
        public string Email;
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
