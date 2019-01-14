using System;

namespace Understandingscope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
                if(i == 9)
                {
                    string l = i.ToString();
                }
                Console.WriteLine(l);
            }
            Console.WriteLine(j);
            Console.WriteLine(k);
            helperMethod();
            Console.ReadLine();
        }
        static void helperMethod()
        {
            Console.WriteLine(k);
        }
    }
}
