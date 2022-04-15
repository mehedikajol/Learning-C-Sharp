namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var box = new Box<Type>();

            var box1 = new Box<int>();
            var box2 = new Box<double>();

            box1.Length = 12;
            box1.Width = 10;
            box1.Height = 8;
            //Console.WriteLine("Box 1 Volume: " + box1.Length* box1.Width* box1.Height);
            //Console.WriteLine("Box 1 Area: " + box1.Length * box1.Width);

            var storage = new Storage<string>(5);

            storage.PutItem(0, "This");
            storage.PutItem(1, "is");
            storage.PutItem(2, "just");
            storage.PutItem(3, "an");
            storage.PutItem(4, "example");

            storage.ShowItems();

            var storage2 = new Storage<int>(2);
            storage2.PutItem(0, 10);
            storage2.PutItem(1, 10);
            storage2.ShowItems();

        }
    }
}
