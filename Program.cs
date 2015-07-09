using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Space Exploration 
            double velocity = 10000d;
            double fiveMinBoost = velocity * 1.5;        
            

            //Here the user is prompt to enter how many minutes they will boost for
            Console.WriteLine("Enter how long do you want to fire boosters (in full minutes)?");
            int time_mins = int.Parse(Console.ReadLine());

            //The ship boosts 5% of it's velocity every 30 secs. 
            //Here time is multiplied by 2 to account for how many times velocity will inc.
            for (int x = 0; x < time_mins * 2;x++ )
            {
                velocity *= 1.05d;//velocity is multiplied by it's former velocity by 1.5 time_mins *2)
            }
            Console.WriteLine("The spaceships velocity is"+velocity+" MPH");//answer

            //Here the Space craft boosts continually for 2 hours for 5 min boosts and 10 minute coasts
            //User can enter as many minutes as they would like with these same rules.
            Console.WriteLine("Enter how many minutes you would like to increase velocity (in full minutes)? ");
            velocity = 10000d;//velocity is returned to it's intial velocity
            time_mins = int.Parse(Console.ReadLine());//time is entered here

            //each cycle can only occur every 15 minutes. Here how many cycles is determined
            for (int cycles = 0; cycles < time_mins / 15; cycles++)
            {
                for (int x = 0; x < 10; x++)//each cycle will incr. velocity 5% 10 times.
                {
                    velocity *= 1.05;
                }
            }
            Console.WriteLine("The spaceships velocity is " + velocity+" MPH");

        }
    }
}
