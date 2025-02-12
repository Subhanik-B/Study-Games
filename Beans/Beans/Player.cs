using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beans
{
    internal class Player
    {
        public String Name {get; set;}
        public int Position {get; set;}
        public double Overall {get; set;}

        public void player(String name, int pos, double over)
        {
            Name = name;
            Position = pos;
            Overall = over;
        }
    }
}
