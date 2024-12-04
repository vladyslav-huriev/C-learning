Console.WriteLine("Enter the first figure: ");
int numberfirst = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second figure: ");
int numbersecond = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the activity what you whant to do with those figures (+, -, *, /): ");
string figures = Console.ReadLine();

try
{
    switch (figures)
    {
        case "+":
            Console.WriteLine($"The result of your calculation is: {numberfirst + numbersecond}");
            break;
        case "*":
            Console.WriteLine($"The result of your calculation is: {numberfirst * numbersecond}");
            break;
        case "-":
            Console.WriteLine($"The result of your calculation is: {numberfirst - numbersecond}");
            break;
        case "/":
            Console.WriteLine($"The result of your calculation is: {numberfirst / numbersecond}");
            break;
        default:
            Console.WriteLine("Error has occured.");
            break;
    }
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error has occured - You cannot devide by 0");
}
