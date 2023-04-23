// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie um programa que solicite ao usuário uma frase e exiba na tela a mesma frase, mas invertida.");

Console.Write("Digite uma frase: ");
string frase = Console.ReadLine();

char[] caracteres = frase.ToCharArray();

Array.Reverse(caracteres);

string fraseInvertida = new string(caracteres);

Console.WriteLine($"Frase invertida: {fraseInvertida}");
