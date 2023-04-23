// See https://aka.ms/new-console-template for more information

Console.WriteLine("Valor a : ");
int.TryParse(Console.ReadLine(), out int a);
Console.Write("Valor b: ");
int.TryParse(Console.ReadLine(), out int b);

Console.WriteLine($" A soma eh : {(a + b)}");