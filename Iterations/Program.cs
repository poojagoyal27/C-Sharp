using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

           
            // string[] names = new string[] {"pooja" , "blackAss" , "fatty" , "skinny"};
            /*   for (int i =0; i<=names.Length; i++)
               {
                   Console.WriteLine(names[i]);
               }
               Console.ReadLine();*/
            /*      foreach(string name in names)
                  {
                      Console.WriteLine(name);
                  }
                  Console.ReadLine();*/

            string zig = "you can help people" + "they will also help you";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach(char zigChar in charArray)
            {
                Console.WriteLine(zigChar);
            }

            Console.ReadLine();       
             }

    }
}
