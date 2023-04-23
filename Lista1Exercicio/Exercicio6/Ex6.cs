// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero.");

float n;

Console.Write("Digite um número inteiro: ");
n = float.Parse(Console.ReadLine());
if (n % 1 == 0)
{
    if (n < 0)
    {
        Console.WriteLine("Este numero eh negativo!");
    }
    if (n == 0)
    {
        Console.WriteLine("Este numero eh igual a 0.");
    }
    if (n > 0)
        Console.WriteLine("Este numero eh positivo.");
}
else
    Console.WriteLine("ERRO! Informe um número inteiro!");
