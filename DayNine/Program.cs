namespace Daynine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test<ExtendedItem>(new ExtendedItem() { A = 10, X = 20, Y = 30, Z = 40 });
         }

        public static void Test<T>(T item) where T : Item
        {
            var x = item.X + item.Y +  item.Z;
            Console.WriteLine(x);
        }

        public interface IItem {
            int X { get; set; }
            int Y { get; set; }
            int Sum(int a, int b);
        }

        public abstract class AItem
        {
            public abstract int Sub(int a, int b, int C);
            static public int Sum(int a, int b)
            {
                return a + b + a + b;
            }
        }
        
        public class Item : IItem
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public int Sum(int a, int b)
            {
                return a + b;
            }
        }

        public class ExtendedItem : Item
        {
            public int A { get; set; }
        }

    }
}