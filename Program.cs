namespace DayFour
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car = new Car();
            car.Model = "2021xBK";
            car.MaxSpeed = 45;
            car.brand = "Nissan";
            Console.WriteLine("Car brand is: " + car.brand + ", Model is: " + car.Model + ", Max Speed is: " + car.MaxSpeed);
            */

            var book = new Book();
            book.Name = "Programming With C Sharp.";
            book.Description = "Best book to learn C Sharp like a pro";
            book.Price = 125;
            book.Author = "E. Balagurusamy";

            var electornics = new Electronics();
            electornics.Name = "Mobile";
            electornics.BrandName = "Nokia";
            electornics.Price = 1200;
            electornics.Description = "Connecting People";

            static void printDetails(Product product)
            {
                Console.WriteLine("Name: "+product.Name);
                Console.WriteLine("Description: "+product.Description);
                
                if(product is Book)
                {
                    var newBook = product as Book;
                    Console.WriteLine($"Author: {newBook.Author}");
                }
                if(product is Electronics)
                {
                    var newElectronics = product as Electronics;
                    Console.WriteLine($"Brand name: {newElectronics.BrandName}");
                }

                Console.WriteLine($"Price: ${product.Price}");
                Console.WriteLine($"Discount: ${product.discountAmount()}");
                Console.WriteLine($"Current Price: ${product.Price - product.discountAmount()} \n");
            }

            printDetails(book);
            printDetails(electornics);

            
        }
    }
}