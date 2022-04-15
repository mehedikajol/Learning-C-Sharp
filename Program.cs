namespace DayFive
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Learning class constructor calling
            /*
            WaterBottle newBottle = new WaterBottle(2, "Red");

            Console.WriteLine("Initial Amount: " + newBottle.CurrentAmount);

            newBottle.AddItem(3);
            Console.WriteLine("After adding 3 litre: " + newBottle.CurrentAmount);

            newBottle.RemoveItem(4);
            Console.WriteLine("Initial removing 4 litre: " + newBottle.CurrentAmount);

            newBottle.AddItem(1);
            Console.WriteLine("After adding 1 litre: " + newBottle.CurrentAmount);
            */

            // Learning Params
            var math = new Math();
            Console.WriteLine(math.Average(15, 25));
            Console.WriteLine(math.Average(4, 10, 68));
            Console.WriteLine(math.Average(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            Console.WriteLine(math.Average(new int[] {5, 6, 84, 74, 58}));


        }
    }
}