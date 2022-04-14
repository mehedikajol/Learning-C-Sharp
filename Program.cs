namespace DayFive
{
    public class WaterBottle
    {
        public int Capacity { get; }   
        public string Color { get; }
        public int WaterAmount { set;get }  

        public WaterBottle(int capacity, string color)
        {
            Capacity = capacity;
            Color = color;
        }

        public void AddWater(int amount)
        {

        }

        public void RemoveWater(int amount)
        {

        }
    }
}