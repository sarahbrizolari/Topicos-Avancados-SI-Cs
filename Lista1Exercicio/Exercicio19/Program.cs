// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie um programa que exiba na tela a sequência de números primos até 100.");

int n;
for (n = 0; n <= 100; n++)
{
    if (n % 1 == 0)
    {
        bool ehPrimo = true;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                ehPrimo = false;
        }
        if (ehPrimo)
            Console.WriteLine($"{n} é um numero primo.");
    }
}
