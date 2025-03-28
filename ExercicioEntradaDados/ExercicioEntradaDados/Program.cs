using System.Globalization;

Console.Write("Informe seu nome completo: ");
string nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.Write("Quantos quartos há em sua casa? ");
//O int.Parse() converte texto digitado para um número Int.
int quartoCasa = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Informe o valor da sua internet: ");
double internetPreco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine();
Console.Write("Informe seu último nome, idade e altura: ");
string linha = Console.ReadLine();
//vetor de texto - divide uma var em outras var quando encontra um campo de espaço (' ').
string[] vetor = linha.Split(' ');
string ultimoNome = vetor[0];
int idade = int.Parse(vetor[1]);
double altura = double.Parse(vetor[2]);
Console.WriteLine(nomeCompleto);
Console.WriteLine(quartoCasa);
Console.WriteLine(internetPreco.ToString("F2");
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2");

