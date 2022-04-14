namespace DayFive
{
    public class Program
    {
        static void Main(string[] args)
        {
            WaterBottle newBottle = new WaterBottle(2, "Red");

            Console.WriteLine("Initial Amount: " + newBottle.CurrentAmount);

            newBottle.AddWater(3);
            Console.WriteLine("After adding 3 litre: " + newBottle.CurrentAmount);

            newBottle.RemoveWater(4);
            Console.WriteLine("Initial removing 4 litre: " + newBottle.CurrentAmount);

            newBottle.AddWater(1);
            Console.WriteLine("After adding 1 litre: " + newBottle.CurrentAmount);

        }
    }
}