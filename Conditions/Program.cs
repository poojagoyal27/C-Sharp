using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Lucky Number");
            Console.Write("Press 1 , 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "you won a new car";
            else if (userValue == "2")
                message = "you won new cat";
            else if (userValue == "3")
                message = "you won a hat";
            else
            {
                message = "invalid input";
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
       
    }
}
