// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("How many employees are in the company");
int emloyees = int.Parse(Console.ReadLine());

double salaryintotal = 0;

for (int i = 1; i <= emloyees; i++)
{
    Console.WriteLine($"What is the salary of the employee #{i}: ");
    salaryintotal += int.Parse(Console.ReadLine());
}

double avaragesalary = salaryintotal / emloyees;
Console.WriteLine($"The avarage salary in the company is: {avaragesalary}");