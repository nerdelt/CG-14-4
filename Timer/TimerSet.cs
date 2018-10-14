using System;
using System.Timers;

namespace UserTimer
{
    public class TimerSet
    {
        public TimeSpan SpanTime { get; set; }
        public Timer timer { get; set; }

        public void SetTimer(string userTime)
        {
            SpanTime = TimeSpan.Parse(userTime);

            myTimer.Elapsed += MyTimer_Elapsed;

        }


        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Ding! Your timer has ended.");
        }

    }
}
