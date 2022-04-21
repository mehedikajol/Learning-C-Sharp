namespace OutParameter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var add = 0;
            var sub = 0;
            var mul = 0;
            var div = 0;
            Calculations(10, 5, out add, out sub, out mul, out div);
            Console.WriteLine($"Out Parameters: \t{add}, {sub}, {mul}, {div}");
        }

        public static void Calculations(int a, int b, out int Add, out int Sub, out int Mul, out int Div)
        {
            Add = a + b;
            Sub = a - b;
            Mul = a * b;
            Div = a / b;
        }
    }
}