using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class RandomWrapper : IRandom

    {
        private Random random;

        public RandomWrapper()
        {
            random = new Random();
        }

        public int Next(int start, int endNotInclusive)
        {
            return random.Next(start, endNotInclusive);
        }
    }
}
