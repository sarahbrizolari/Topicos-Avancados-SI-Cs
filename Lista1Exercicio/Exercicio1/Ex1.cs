Console.WriteLine("Faça um programa que receba dois números e retorne a soma, a subtração, a multiplicação e a divisão entre eles.");

Console.WriteLine("Digite o primeiro numero: ");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
float n2 = float.Parse(Console.ReadLine());

float soma = n1 + n2;
float sub = n1 - n2;
float mult = n1 * n2;
float div = n1 / n2;

Console.WriteLine($"Soma: {soma},  Subtracao: {sub},  Divsao: {div},  Multiplicacao: {mult}");


