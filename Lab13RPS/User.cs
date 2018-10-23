using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class User : Player
    {
        public User() : base("Player 1")
        {

        }
        public override string GenRPS()
        {
            Console.WriteLine("Pick one: \n" +
                "1) Rock \n" +
                "2) Paper \n" +
                "3) Scissors");
            string input = Console.ReadLine();
            int.TryParse(input, out int pick);
            bool isNumber = NumberPicked(pick);
            
            if (isNumber == true)
            {
                switch (pick-1)
                {
                    case 0:
                        return RPS.Rock;
                        break;
                    case 1:
                        return RPS.Paper;
                        break;
                    case 2:
                        return RPS.Scissors;
                        break;
                    default:
                        return RPS.Rock;
                       
                }


            }
            else
            {
                Console.WriteLine("You didnt pick Rock, Paper, or Scissors. So I chose for you");
                return RPS.Rock;
            }

            
        }

        public static bool NumberPicked(int num)
        {
            if (num < 1 || num > 3)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
