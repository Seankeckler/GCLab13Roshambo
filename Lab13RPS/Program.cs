using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Player one = new User();
            Player bebop = new Randy(r);
            Player rocky = new Rocksteady();
            bool TF = true ;
            string oneOrtwo;
            string RockyorBebop;
            string rocksteadysChoice = rocky.GenRPS();
            string bebopsChoice = bebop.GenRPS();
            do
            {
            Console.Clear();
            RockyorBebop = Mainmenu();
            oneOrtwo = WhichGoon(RockyorBebop);
            string player1sChoice = one.GenRPS();
            TheFight(player1sChoice, oneOrtwo, rocksteadysChoice, bebopsChoice);
            TF = TorF();
            } while (TF == true);
        }

        static bool TorF()
        {
            Console.WriteLine("Do you want to play again? y/n");
            string answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Thats not an option");
                Console.ReadKey();
                return true;
            }
        }

        static string Mainmenu( )
        {
            Console.WriteLine("Turtles it looks like Shredder sent his goons out again \n" +
                "Who do you want to fight? 1 or 2");
            Console.WriteLine("1) Rocksteady \n" +
                "2) Bebop");
            string whoToFight = Console.ReadLine();
            return whoToFight;
        }
        static string WhichGoon(string RockorBebop)
        {
            
           

            if (RockorBebop == "1")
            {
                Console.WriteLine("Grab the Rhino by the horn");
                return "1";
            }
            else if (RockorBebop == "2")
            {
                Console.WriteLine("Time to fry some bacon");
                return "2";
            }
            else
            {
                Console.WriteLine("The foot clan has jumped you from behind");
                return null;
                
            }

        }

        static void TheFight(string user, string RockorBebop, string Rocky, string Bebop)
        {
            //Rocky
            if (RockorBebop == "1")
            {
                if (user == Rocky)
                {
                    Console.WriteLine("Rocksteady's choice: " + Rocky);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("Draw");
                }
                else if (user == "Scissors")
                {
                    Console.WriteLine("Rocksteady's choice: " + Rocky);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("Shell Shocked, The Rhino eats your pizza");
                }
                else
                {
                    Console.WriteLine("Rocksteady's choice: " + Rocky);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("You Win, Cawabunga Dude!");
                }
            }
            //Bebop
            else if (RockorBebop == "2")
            {
                if (user == Bebop)
                {
                    Console.WriteLine("Bebop's choice: " + Bebop);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("Draw");
                }
                else if (user == "Rock" && Bebop == "Paper")
                {
                    Console.WriteLine("Bebop's choice: " + Bebop);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("Shell Shocked, The Pig eats your pizza");
                }
                else if (user == "Rock" && Bebop == "Scissors")
                {
                    Console.WriteLine("Bebop's choice: " + Bebop);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("You Win, Cawabunga Dude!");
                }
                else if (user == "Scissors" && Bebop == "Rock")
                {
                    Console.WriteLine("Bebop's choice: " + Bebop);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("Shell Shocked, The Pig eats your pizza");
                }
                else if (user == "Scissors" && Bebop == "Paper")
                {
                    Console.WriteLine("Bebop's choice: " + Bebop);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("You Win, Cawabunga Dude!");
                }
                else if (user == "Paper" && Bebop == "Scissors")
                {
                    Console.WriteLine("Bebop's choice: " + Bebop);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("Shell Shocked, The Pig eats your pizza");
                }
                else
                {
                    Console.WriteLine("Bebop's choice: " + Bebop);
                    Console.WriteLine("Your choice: " + user);
                    Console.WriteLine("You Win, Cawabunga Dude!");
                }
            }
            else
            {
                Console.WriteLine("Didn't you get beat up by the foot clan?");
                Console.ReadKey();
            }

        }
       
    }
}
