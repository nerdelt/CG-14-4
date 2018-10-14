using System;
using System.Timers;

namespace UserTimer
{
    public class TimerSet
    {
        public TimeSpan ParsedTime { get; set; }
        public Timer UserTimer { get; set; }
        public Double TimerInput { get; set; }

        public void SetTimer(string inputTime)
        {
            //parses user input string to timespan
            ParsedTime = TimeSpan.Parse(inputTime);

            //shows duration of user input to let user know if their input was correct
            TimeSpan duration = ParsedTime.Duration();

            Console.WriteLine($"\nYour timer is set for {duration}");
        }

        public void StartTimer(string start)
        { 

            //turns user input into milliseconds to enter into timer
            TimerInput = ParsedTime.TotalMilliseconds;

            //creates a new tier with user input 
            UserTimer = new Timer(TimerInput);

            //starts timer
            UserTimer.Start();

            //adds to event handler
            UserTimer.Elapsed += UserTimer_Elapsed;
         
         }

        private void UserTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //shows timer message in blue color
            Console.ForegroundColor = ConsoleColor.Blue;

            //stops timer 
            UserTimer.Stop();

            //lets user know timer has finished
            Console.WriteLine("\nDing! Your timer has ended.");
        }
    }
}