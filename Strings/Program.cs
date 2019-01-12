using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string myString = "My \"So-Called\" life";

            //     string myString = "My \n life";
            //     string myString = "go to ypur c:\\ drive";

            //    string myString = @"go to ypur c:\ drive";
            //  string myString = String.Format("{0}= {1}","First", "Second");

            //   string myString = String.Format("{0:C}",123.45 );
            //   string myString = String.Format("{0:N}", 12345);
            //   string myString = String.Format("{0:P}", .123);
            // string myString = String.Format("{0:(###) ###-####}, 1234567890);

            //string myString = " That Summer we took  ";
            //  myString = myString.Substring(6, 14);



            //      myString = String.Format("Length before: {0} ---- length after{1}",  myString.Length,myString.Trim().Length);
            /*  string myString = "";
                for(int i =0; i < 100; i++)
              {
                  myString += "--" + i.ToString();
              }*/

            StringBuilder myString = new StringBuilder();
            for(int i =0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
