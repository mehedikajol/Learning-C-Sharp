using System;

namespace StaticKeyword
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math.Z = 4;
            var math = new Math();
            math.X = 10;
            math.Y = 20;
            var sum = math.Sum();
            var mult = math.Multiply();
            Console.WriteLine($"Sum: {sum}, Multiply: {mult}");

            var math2 = new Math();
            math2.X = 20;
            math2.Y = 30;
            var sum2 = math2.Sum();
            var mult2 = math2.Multiply();
            Console.WriteLine($"Sum: {sum2}, Multiply: {mult2}");

            Console.WriteLine(Math.Divide());
        }
    }

    public class Math
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static int Z { get; set; }

        public int Sum()
        {
            return X + Y + Z;
        }

        public int Multiply()
        {
            return X * Y * Z;
        }

        public static int Divide()
        {
            return Z + 10;
        }
    }
}
