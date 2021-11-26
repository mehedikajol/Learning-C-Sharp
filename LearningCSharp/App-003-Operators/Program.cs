//Operators


// Arithmetic Operators + - * / %
/*
#region Arithmetic Operators
var number1 = 45;
var number2 = 20;

Console.WriteLine(number1 + number2); // Addition
Console.WriteLine(number1 - number2); // Subtraction   
Console.WriteLine(number1 * number2); // Multiplication
Console.WriteLine(number1 / number2); // Division
Console.WriteLine(number1 % number2); // Reminder

#endregion
*/

// Relational Operators == != > >= < <=
/*
#region Relational Operators
var number1 = 45;
var number2 = 20;

if (number1 == number2)
    Console.WriteLine("Two numbers are equal");
if (number1 != number2)
    Console.WriteLine("Two numbers are not equal");
if (number1 > number2)
    Console.WriteLine("Number1 is greater than number2");
if (number1 >= number2)
    Console.WriteLine("Number1 is greater or equal to number2");
if (number1 < number2)
    Console.WriteLine("Number1 is smaller than number2");
if (number1 <= number2)
    Console.WriteLine("Number1 is smaller or equal to number2");

#endregion
*/

// Logical Operators && || !
/*
#region Logical Operators

var number1 = true;
var number2 = false;

if (number1 || number2)
    Console.WriteLine("Logical OR Operator");
if(number1 && number2)
    Console.WriteLine("Logical AND Operator");
if (number1 && !number2)
    Console.WriteLine("Logical NOT Operator");

#endregion
*/

// Bitwise Operators & | ^ ~ >> <<
/*
#region Bitwise Operators

var number1 = 45; // 00101101
var number2 = 20; // 00010100

Console.WriteLine("Bitwise OR Operation "+(number1|number2) + " "+ Convert.ToString(number1|number2, 2));
Console.WriteLine("Bitwise AND Operation " + (number1 & number2) + " " + Convert.ToString(number1 & number2, 2));
Console.WriteLine("Bitwise X-OR Operation " + (number1 ^ number2) + " " + Convert.ToString(number1 ^ number2, 2));
Console.WriteLine("Bitwise NOT Operation " + (~number1) + " " + Convert.ToString(~number1, 2));
Console.WriteLine($"Bitwise Right Shift Operation , {number1} becomes " + (number1>>1) + " " + Convert.ToString(number1>>1, 2));
Console.WriteLine($"Bitwise Left Shift Operation , {number1} becomes " + (number1 << 1) + " " + Convert.ToString(number1 << 1, 2));

#endregion
*/

// Assignment Operators = += -= *= /= %= &= |= ^=
/*
#region Assignment Operators

var number1 = 45;
Console.WriteLine($"Original number is {number1}");
Console.WriteLine("Adding 10: " + (number1 += 10));
number1 = 45;
Console.WriteLine("Subtracting 10: " + (number1 -= 10));
number1 = 45;
Console.WriteLine("Multiplying by 10: " + (number1 *= 10));
number1 = 45;
Console.WriteLine("Dividing by 10: " + (number1 /= 10));
number1 = 45;
Console.WriteLine("Reminder by 10: " + (number1 %= 10));
number1 = 45;
Console.WriteLine("Bitwise AND with 10: " + (number1 &= 10));
number1 = 45;
Console.WriteLine("Bitwise OR with 10: " + (number1 |= 10));
number1 = 45;
Console.WriteLine("Bitwise X-OR with 10: " + (number1 ^= 10));
#endregion
*/

// Increament and Decrement Operators ++ --

#region

var number1 = 5;
Console.WriteLine(number1);
Console.WriteLine(number1++);
Console.WriteLine(number1 + "\n");

number1 = 5;
Console.WriteLine(number1);
Console.WriteLine(number1--);
Console.WriteLine(number1 + "\n");

number1 = 5;
Console.WriteLine(number1);
Console.WriteLine(++number1);
Console.WriteLine(number1 + "\n");

number1 = 5;
Console.WriteLine(number1);
Console.WriteLine(--number1);
Console.WriteLine(number1 + "\n");

#endregion

