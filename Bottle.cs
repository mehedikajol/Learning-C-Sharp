using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFive
{
    public abstract class Bottle
    {
        public int Capacity { get; }
        public string Color { get; }
        public int CurrentAmount { get; private set; }

        public Bottle(int capacity, string color)
        {
            Capacity = capacity;
            Color = color;
            CurrentAmount = 0;
        }
        public void AddItem(int amount)
        {
            if (CurrentAmount + amount > Capacity) CurrentAmount = Capacity;
            else CurrentAmount += amount;
        }

        public void RemoveItem(int amount)
        {
            if (amount > CurrentAmount) CurrentAmount = 0;
            else CurrentAmount -= amount;
        }
    }
}
