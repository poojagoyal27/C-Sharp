using System;

namespace Datesandtimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //  DateTime myvalue = DateTime.Now;
            //  Console.WriteLine(myvalue.ToString());   //whole time
            //  Console.WriteLine(myvalue.ToShortDateString());   // only date
            //  Console.WriteLine(myvalue.ToShortTimeString()); // time only hour and minutes
            //  Console.WriteLine(myvalue.ToLongTimeString()); //seconds , minutes , hour
            //   Console.WriteLine(myvalue.ToLongDateString()); //tells day too

            //     DateTime Time Math

            //  Console.WriteLine(myvalue.AddDays(3).ToLongDateString()); //add days to date


            //     Console.WriteLine(myvalue.AddHours(3).ToLongTimeString()); //add hours

            //      Console.WriteLine(myvalue.AddHours(-3).ToLongTimeString()); //subtract hours

            //      Console.WriteLine(myvalue.Month);

            //    DateTime mybirthday = new DateTime(1995, 09 , 27);
            //    Console.WriteLine(mybirthday.ToShortDateString());


            DateTime mybirthday = DateTime.Parse("09/27/1995");
            TimeSpan myAge = DateTime.Now.Subtract(mybirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
