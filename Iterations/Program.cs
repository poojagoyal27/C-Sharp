using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[] numbers = new int[5];
           string[] names = new string[] {"pooja" , "blackAss" , "fatty" , "skinny"};
         /*   for (int i =0; i<=names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();*/
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

    }
}
