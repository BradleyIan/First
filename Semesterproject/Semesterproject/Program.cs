using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semesterproject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("You awake in a dark room with a tv on the opposite side. It takes a minute, but you slowly start to remember all the details of your life.");
            Console.WriteLine("You remembered that your name is: (Please type a name)");
            string name = Console.ReadLine();
            Console.WriteLine("Ah yes, your name is " + name + " .");
            Console.WriteLine("Without seeing anything else to do, you approach the tv. Suddenly, the tv turned on to display a dark sillouitte.");
            Console.WriteLine("'Hello random individual. You've been randomly selected to partake in a challenge, and if you complete this challenge you will get a lot of money!'");
            Console.WriteLine("'Are you ready to start?'");
            Console.WriteLine("(Type the number of your response)");
            Console.WriteLine("1:'Okay.'");
            Console.WriteLine("2:'No. I want to leave!'");
            string yn = Console.ReadLine();
            string answer = "";
            if (yn == "1")
            {
                answer = "yes";
                Console.WriteLine("Great proceed through the door behind this tv.");
            }
            else if (yn == "2")
            {
                Console.WriteLine("Aw...alright fine. You can leave if you want to. There's a door behind you that leaves outside. But are you sure you want to miss out on this oppertunity?");
                Console.WriteLine("The only risk of death is if you stay in a room for too long and die of starvation!");
                Console.WriteLine("Type 1 to change your mind");
                Console.WriteLine("Type 2 to leave.");
                string Schoice = Console.ReadLine();
                if ( Schoice == "1")
                {
                    Console.WriteLine("Alright, great! Proceed through the door behind the tv.");
                    Room1();
                }
                else if (Schoice == "2")
                {
                    Console.WriteLine("You opened the door and left the building.");
                    
                }
            }
            while (answer == "yes") 
            {
                Room1();
            }
            
            
          
        }
        private static void Room1()
        {
            Console.WriteLine("You entered the first room.");
        }
    }
}
