using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class Player
    {
        string name;
        string RPSValue;

        public Player(string name)
        {
            this.name = name;
        }

        public virtual string GenRPS()
        {
            return RPS.Rock;
        }
    }
}
