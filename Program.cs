Console.WriteLine("What day is it today (1-7)?");
string input = Console.ReadLine();

if (int.TryParse(input, out int numberoftheday))
{
    switch (numberoftheday)
        {
        case 1:
            Console.WriteLine("That means that today is Monday"); break;
        case 2:
            Console.WriteLine("That means that today is Tuesday"); break;
        case 3:
            Console.WriteLine("That means that today is Wednesday"); break;
        case 4:
            Console.WriteLine("That means that today is Thursday"); break;
        case 5:
            Console.WriteLine("That means that today is Friday"); break;
        case 6:
            Console.WriteLine("That means that today is Saturday"); break;
        case 7:
            Console.WriteLine("That means that today is Sunday"); break;
        default:
            Console.WriteLine("Please enter a number between 1 and 7");
            break;
    }
}
