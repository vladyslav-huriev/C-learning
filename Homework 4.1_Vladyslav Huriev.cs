// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//int x = 10;
//int y = 5;

// int result = x / y;
// Console.WriteLine(result);

Console.WriteLine("What day is it today (1-7)?");
int numberoftheday = int.Parse(Console.ReadLine());

if (numberoftheday == 1) Console.WriteLine("That means that today is Monday");
if (numberoftheday == 2) Console.WriteLine("That means that today is Tuesday");
if (numberoftheday == 3) Console.WriteLine("That means that today is Wednesday");
if (numberoftheday == 4) Console.WriteLine("That means that today is Thursday");
if (numberoftheday == 5) Console.WriteLine("That means that today is Friday");
if (numberoftheday == 6) Console.WriteLine("That means that today is Saturday");
if (numberoftheday == 7) Console.WriteLine("That means that today is Sunday");