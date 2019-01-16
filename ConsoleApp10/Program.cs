using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;    // Hämtar datum
            
            Console.WriteLine(timeNow);//skriver ut datum
            Console.WriteLine(timeNow.ToString());    // gör samma som föregående rad
            Console.WriteLine(timeNow.ToShortDateString());//skriver ett kort datum
            Console.WriteLine(timeNow.ToLongDateString()); //skriver datumet större format alltså med tid efter också
            Console.WriteLine(timeNow.ToString("yy-dd-MM")); // skriver ut år månad dag med 2 siffror o - emellan ex. 75-07-19

            DateTime timeMod = timeNow.AddHours(-1); // tar klockslaget just nu och minskar en timme

            Console.WriteLine(timeMod);  //skriver ut föregående rad

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
        
    

