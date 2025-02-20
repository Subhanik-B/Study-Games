using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartet2
{
    internal class Hand
    {
        List<CarCard> carCards;

        public CarCard getTop()
        {
            return carCards[0];
        }
    }
}
