
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the Cyan timer");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;

            Console.WriteLine("Press enter again to remove white and continue Cyan");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            Console.WriteLine("Please enter to actvate both timer and change Cyan color to Red");
            Console.ReadLine();

            myTimer.Elapsed += MyTimer_Elapsed;

            // Console.ReadLine();

            Console.WriteLine("Please enter to stop the timer");


            Console.ReadLine();


        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Elaspesd1: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
