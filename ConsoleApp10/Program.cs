using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;    // Gets current system time

            Console.WriteLine(timeNow);
            Console.WriteLine(timeNow.ToString());    // same as above
            Console.WriteLine(timeNow.ToShortDateString());
            Console.WriteLine(timeNow.ToLongDateString());
            Console.WriteLine(timeNow.ToString("yy-dd-MM"));

            DateTime timeMod = timeNow.AddHours(-1);

            Console.WriteLine(timeMod);

            TimeSpan timeSpan = new TimeSpan(12, 45, 30);

            DateTime timeModSpan = timeNow.Add(timeSpan);

            Console.WriteLine(timeModSpan);

            Console.ReadKey();

            DoWhileWorkTime(timeModSpan);

            DateTime myB_Day = new DateTime(1982, 08, 25);

            Console.WriteLine(myB_Day);

            Console.ReadKey();
        }

        static void DoWhileWorkTime(DateTime time)
        {
            DateTime endOfWorkDay = time;

            do
            {
                Console.WriteLine(endOfWorkDay.ToShortTimeString());
                endOfWorkDay = endOfWorkDay.AddHours(1);
            } while
            (endOfWorkDay.Hour < 16 || (endOfWorkDay.Hour <= 16 && endOfWorkDay.Minute <= 30));


        }
    }
}
        
    

