namespace DayFour
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Model = "2021xBK";
            car.MaxSpeed = 45;
            car.brand = "Nissan";
            Console.WriteLine("Car brand is: " + car.brand + ", Model is: " + car.Model + ", Max Speed is: " + car.MaxSpeed);

            var products = new Product[2];

            var book = new Book();
            book.Name = "Programming With C Sharp.";
            book.Description = "Best book to learn C Sharp like a pro";
            book.Price = 125;
            book.Author = "E. Balagurusamy";
            products[0] = book;

            var electornics = new Electronics();
            electornics.Name = "Mobile";
            electornics.BrandName = "Nokia";
            electornics.Price = 1200;
            electornics.Description = "Connecting People";
            products[1] = electornics;

            Console.WriteLine(((Electronics)products[1]).BrandName);
        }
    }
}