// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie um programa que solicite ao usuário um número e exiba na tela se ele é um número de Armstrong ou não.");

Console.Write("Digite um numero: ");
int n = int.Parse(Console.ReadLine());

int nDigitos = 0;
int nTemp = n;

while (nTemp > 0)
{
    nDigitos++;
    nTemp /= 10;
}

int soma = 0;
nTemp = n;
while (nTemp > 0)
{
    int digito = nTemp % 10;
    soma += (int)Math.Pow(digito, nDigitos);
    nTemp /= 10;
}

if (soma == n)
{
    Console.WriteLine($"{n} é um número de Armstrong.");
}
else
{
    Console.WriteLine($"{n} não é um número de Armstrong.");
}