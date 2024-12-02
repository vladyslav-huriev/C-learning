// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the first figure: ");
int numberfirst = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second figure: ");
int numbersecond = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the activity what you whant to do with those figures (+, -, *, /): ");
string figures = Console.ReadLine();

switch (figures)
{
    case "+":
        Console.WriteLine($"The result of your calculation is: {numberfirst + numbersecond}");
        break;
    case "-":
        Console.WriteLine($"The result of your calculation is: {numberfirst - numbersecond}");
        break;
    case "*":
        Console.WriteLine($"The result of your calculation is: {numberfirst * numbersecond}");
        break;
    case "/":
        if (numbersecond != 0)
            Console.WriteLine($"The result of your calculation is: {numberfirst / numbersecond}");
        else
            Console.WriteLine("Error has occured - You can not delete to 0.");
        break;
    default:
        Console.WriteLine("Error has occured.");
        break;
}