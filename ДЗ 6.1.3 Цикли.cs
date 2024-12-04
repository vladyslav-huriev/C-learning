// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the largest number to find prime numbers: ");
int largestNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Prime numbers from 1 to " + largestNumber + " are:");
for (int i = 2; i <= largestNumber; i++)
{
    bool isPrime = true;

    for (int j = 2; j * j <= i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(i);
    }
}
