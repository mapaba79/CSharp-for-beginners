Console.WriteLine("--- Temperature Converter ---");
Console.WriteLine("1 - Celsius to Fahrenheit | 2 - Fahrenheit to Celsius");
Console.Write("Choice: ");

string choice = Console.ReadLine() ?? "1";

Console.Write("Enter the temperature value: ");
double value = double.Parse(Console.ReadLine() ?? "0");

if (choice == "1")
{
  double fahrenheit = (value * 9 / 5) + 32;
  Console.WriteLine($"{value}°C -> {fahrenheit:F2}°F");
}
else
{
  double celsius = (value - 32) * 5 / 9;
  Console.WriteLine($"{value}°F -> {celsius:F2}°C");
}
