using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class JuiceBottle : Bottle
    {
        private string Pipe { set; get; }
        private string Belt { set; get; }
        public JuiceBottle(int capacity, string color)
            : base(capacity, color)
        {

        }
    }
}
