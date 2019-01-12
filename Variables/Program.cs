using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             int y;
           int  x = 5;
             y = x + 7;
             Console.WriteLine(y);
             Console.ReadLine();
             */
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name:");
            string myFirstname;
            myFirstname = Console.ReadLine();

            string myLastname;
            Console.Write("Type your last name:");
            myLastname = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstname + " " + myLastname);
            Console.ReadLine();
         }

    }
}
