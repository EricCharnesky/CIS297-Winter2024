using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee;

namespace YahtzeeTests
{
    internal class NotRandom : IRandom
    {
        List<int> values;
        int currentValueIndex = 0;
        public NotRandom(List<int> values) {
            this.values = values;
        }
        public int Next(int start, int endNotInclusive)
        {
           return values[currentValueIndex++];
        }
    }
}
