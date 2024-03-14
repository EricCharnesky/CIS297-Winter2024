using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Player
    {
        // just for fun players can give themselves infinite money since it's public
        public int Money { get; set; }

        public HoldemHand? HoldemHand { get; set; }

        public Player()
        {
            HoldemHand = null;
            Money = 100;
        }


    }
}
