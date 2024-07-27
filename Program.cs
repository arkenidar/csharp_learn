using static Factors;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("4: " + CountFactorsToString(4));
Console.WriteLine("8: " + CountFactorsToString(8));
Console.WriteLine("12: " + CountFactorsToString(12));

long number = 4444488889;
Console.WriteLine(number + ": " + CountFactorsToString(number));
