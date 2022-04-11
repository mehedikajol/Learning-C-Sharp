using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour
{
    internal class Car
    {
        private string model;
        public string brand;
        private int maxSpeed;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set {
                if (value <= 60)
                    maxSpeed = value;
                else maxSpeed = 60;
            }
        }
    }
}
