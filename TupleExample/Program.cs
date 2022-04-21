namespace TupleExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var time = DateTime.Now;
            var name = "Beautiful Name";
            var person = (name, 26, married: false, 2.6, time);

            Console.WriteLine($"Name: {person.name}");
            Console.WriteLine($"Age: {person.Item2} years");
            Console.WriteLine($"Marrige Status: {person.married}");
            Console.WriteLine($"Job Experience: {person.Item4} year(s)");
            Console.WriteLine($"Time: {person.time} \n\n");

            var ListOfPersons = new List<(int age, string name, double weight)>();

            for (int i = 1; i <= 10; i++)
                ListOfPersons.Add((i + 15, $"Mr. {i * 10 + 100}", Math.Round((Double)(i+6)*10.02, 2)));
            
            foreach (var personDetail in ListOfPersons)
                Console.WriteLine($"Name: {personDetail.name}, Age: {personDetail.age}, Weight: {personDetail.weight}");
            
            
            var result = GetPersonResult();
            Console.WriteLine($"Name: {result.name}, Age: {result.age}, Course: {result.result.Subject}, Grade: {result.result.Grade}");
        
        }
        
        static (string name, int age, Result result) GetPersonResult()
        {
            return ("Bangladesh", 51, new Result( "c-sharp", 3.64));
        }

        
    }
}