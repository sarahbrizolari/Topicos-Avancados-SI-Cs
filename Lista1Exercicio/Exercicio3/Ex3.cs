// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa que leia três números e informe qual deles é o maior.");

Console.WriteLine("Digite um numero: ");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite outro numero: ");
float n2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite ultimo numero: ");
float n3 = float.Parse(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"O numero {n1} eh o maior");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"O numero {n2} eh o maior");
}
else
{
    Console.WriteLine($"O numero {n3} eh o maior");
}
