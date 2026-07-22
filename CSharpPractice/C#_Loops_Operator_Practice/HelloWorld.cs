using System;

Console.WriteLine("=================================");
Console.WriteLine("     Welcome to C# & .NET");
Console.WriteLine("=================================");

Console.Write("Enter your name: ");
string? name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your city: ");
string? city = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("------ Student Details ------");
Console.WriteLine($"Name : {name}");
Console.WriteLine($"Age  : {age}");
Console.WriteLine($"City : {city}");

Console.WriteLine();
Console.WriteLine("Program executed successfully.");