Console.WriteLine("Today, I am going to learn C# datatypes!!\n");

var fullNumber = 15;
var fractionNumber = 15.00F;
var realNumber = 15.0;
var character = 'A';
var realName = "Mehedi Hasan Kajol";

Console.Write("Enter an integer: ");
fullNumber = int.Parse(Console.ReadLine());
Console.Write("Enter an float: ");
fractionNumber = float.Parse(Console.ReadLine());
Console.Write("Enter an double: ");
realNumber = double.Parse(Console.ReadLine());
Console.Write("Enter an character: ");
character = char.Parse(Console.ReadLine());
Console.Write("Enter an name: ");
realName = Console.ReadLine();
Console.WriteLine($"Your name is {realName}, \nyour inputed integer is {fullNumber}, \nyour inputed float is {fractionNumber}, \nyour inputed double is {realNumber}, \nand character is {character}");