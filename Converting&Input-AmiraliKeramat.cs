// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please Enter your Name :");
string Name = Console.ReadLine();
Console.WriteLine("Please Enter Your Age :");
byte Age = Convert.ToByte(Console.ReadLine());

Console.WriteLine($"Hello, {Name}. You are {Age} years old");
Console.ReadKey();