using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public class JuiceBottle : Bottle
    {
        private const string PIPE = "Stripe";
        private string Pipe { set; get; }
        private string Belt { set; get; }
        public JuiceBottle(int capacity, string color, string pipe)
            : base(capacity, color)
        {

        }
        public JuiceBottle(string color, int capacity, int x)
            : base(capacity, color)
        {

        }
        public JuiceBottle(int capacity, string color)
            : this(capacity, color, PIPE)
        {

        }
    }
}
