// DATA TYPES
/*
int x = 5;
double y = 6.5;
string z = "temp";
bool a = true;
char c = 'a';

Console.WriteLine(a);
Console.WriteLine(c);
Console.WriteLine(z);
Console.WriteLine(x);
Console.WriteLine(y);
*/

// DATA TYPES USING VAR
/*
var a = 5;
var b = 5.4;
var c = 'v';
var d = false;
var e = "this is a string";

Console.WriteLine(e);
Console.WriteLine(d);
Console.WriteLine(c);
Console.WriteLine(b);
Console.WriteLine(a);
*/

// ARRAYs
/*
string[] names = new string[5];
names[0] = "Dhaka";
names[1] = "Rajshahi";
names[2] = "Rangpur";
names[3] = "Sylhet";
names[4] = "Barishal";

for( var i=0; i<=4; i++){
    Console.WriteLine(names[i]);
}
*/

// FUNCTIONS or METHODS
/*
static int DivideResult(int a, int b, int c, int numbers){
    return (a + b + c) / numbers;
}
Console.WriteLine(DivideResult(15, 5, 4, 5));
*/

// JAGGED ARRAYs
/*
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[5];
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[2];

jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
jaggedArray[1] = new int[] { 1, 2, 3 };
jaggedArray[2] = new int[] { 1, 2 };

int[][] jaggedArray2 = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 1, 2, 3, 4},
    new int[] { 11, 12}
};
Console.WriteLine(jaggedArray[0][0]);
*/

// JAGGED with MULTIDIMENTIONAL ARRAYs
/*
int[][,] jaggedMulti = new int[3][,]
{
    new int[,] {{ 1, 2 }, { 3, 4}},
    new int[,] {{ 10, 20 }, { 30, 40}},
    new int[,] {{100, 200}, {300, 400}}
};
Console.WriteLine(jaggedMulti[2][1, 0]);
*/

// FOR LOOP
/*
for(var i=0; i < 10; i++)
{
    Console.WriteLine((i + 1) * 10);
}
*/

// WHILE LOOP
/*
int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}
*/

// DO WHILE LOOP
/*
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 10);
*/

// FOREACH LOOP
int[] array = new int[5];
array[0] = 10;
array[1] = 11;
array[2] = 12;
array[3] = 13;
array[4] = 14;

foreach(int i in array)
{
    Console.WriteLine(i);
}
