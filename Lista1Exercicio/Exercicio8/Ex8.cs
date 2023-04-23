// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa que leia uma string e informe quantas vezes uma determinada letra aparece na string.");

string stg = "";
char letra;
int contador = 0;

Console.Write("Digite uma pequena frase: : ");
stg = Console.ReadLine();

Console.Write("Qual que deseja ser contada?: ");
letra = char.Parse(Console.ReadLine());

for (int i = 0; i < stg.Length; i++)
{
    if (stg[i] == letra)
        contador++;
}
Console.WriteLine($"A letra {letra} apareceu {contador} vezes.");
