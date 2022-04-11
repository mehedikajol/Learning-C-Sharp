namespace DayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kajol = new Person();
            kajol.name = "Mehedi Hasan Kajol";
            kajol.age = 26;
            kajol.weight = 64.85;
            kajol.height = 187.3;
            Console.WriteLine($"Name: {kajol.name}, Age: {kajol.age}, Weight: {kajol.weight}, Height: {kajol.height}");
            /*Console.WriteLine(kajol.name);
            Console.WriteLine(kajol.age);
            Console.WriteLine(kajol.height);
            Console.WriteLine(kajol.weight);*/
        }
    }
}