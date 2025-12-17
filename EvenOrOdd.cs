Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine() ?? "0");

if (number % 2 == 0)
{
  Console.WriteLine($"{number} is even!");
}
else
{
  Console.WriteLine($"{number} is odd!");
}
