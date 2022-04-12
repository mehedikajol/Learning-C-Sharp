using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        protected double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price >= 0)
                    _price = value;
                else _price = 0;
            }
        }

        public virtual double discountAmount()
        {
            return _price * 15 / 100.0;
        }
    }
}
