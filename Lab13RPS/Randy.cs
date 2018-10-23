using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class Randy : Player
    {
        Random r;

        public Randy(Random r) : base("Randy")
        {
            this.r = r;
        }

        public override string GenRPS()
        {
            int pick = r.Next(0, 3);

            switch (pick)
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
                    break;
            }

            
        }
    }
}
