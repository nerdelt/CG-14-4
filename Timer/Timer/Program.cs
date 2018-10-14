using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UserTimer
{
    class Program
    {
        static void Main(string[] args)
        {

            //lots of explanation here to user 
            Console.WriteLine("This program allows you to set a timer in hours, minutes, seconds, or all three.");
            Console.WriteLine("\nThe format of the timer is HH:MM:SS." +
                "\n\nFor instance, a timer set for one hour and 15 minutes looks like this: 01:15:00 or 1:15");
            Console.WriteLine("\nA timer for 15 seconds can be set like this: 00:00:15, or 0:0:15");
            Console.WriteLine("\nIf you type in only a whole number, that is the number of HOURS the timer will be set for.");
            Console.Write("\nPlease set your timer: ");

            //assigns user input to string 
            string inputTime = Console.ReadLine();

            //creates a new timerset object 
            TimerSet timer = new TimerSet();

            //checks for exceptions 
            try
            {
                timer.SetTimer(inputTime);
                Console.Write("\nTo start timer, press ENTER.");           
            }

            catch(Exception ex)
            {
                Console.WriteLine($"\nSorry, we could not start your timer.");
            }

            //starts timer after user presses enter 
            string start = Console.ReadLine();
            timer.StartTimer(start);   

            Console.ReadLine();


        }
       
    }
}
