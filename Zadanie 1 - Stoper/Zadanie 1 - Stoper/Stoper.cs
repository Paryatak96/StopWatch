using System;
using System.Diagnostics;
using System.Threading;

namespace Zadanie_1___Stoper
{
    class Stoper
    {
        private readonly static Stopwatch stopwatch = new Stopwatch();

        public static void Start ()
        {
            stopwatch.Start();   
        }
        public static void Stop()
        {
            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
            Console.WriteLine("Zmierzony czas to: " + elapsedTime);
            Console.WriteLine("Naciśnij 'ENTER' aby powrócić!");
            Console.ReadLine();
            stopwatch.Reset();
        }
    }
}
