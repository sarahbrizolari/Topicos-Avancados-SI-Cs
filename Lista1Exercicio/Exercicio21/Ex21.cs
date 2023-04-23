// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie um programa que solicite ao usuário um número e exiba na tela se ele é um número triangular ou não.");


Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());
int produto = 1;
int i = 1;

while (produto < numero)
{
    produto *= i;
    i++;
}
if (produto == numero)
{
    Console.WriteLine($"{numero} é um número triangular.");
}
else
{
    Console.WriteLine($"{numero} não é um número triangular.");
}
