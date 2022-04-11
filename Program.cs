namespace DayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            /*Console.Write("Enter Name: ");
            string name;
            name = Console.ReadLine();*/

            person.age = 26;
            person.weight = 64.85;
            person.height = 187.3;
            Console.WriteLine($"Name: {person.name}, Age: {person.age}, Weight: {person.weight}, Height: {person.height}");
            
            person.walk();
        }
    }
}