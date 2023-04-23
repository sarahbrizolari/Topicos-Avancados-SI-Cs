// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual eh a sua idade? ");
int.TryParse(Console.ReadLine(), out int idade);

string msg = (idade >= 18) ? "Maior de Idade" : "Menor de idade";
Console.WriteLine(msg);
