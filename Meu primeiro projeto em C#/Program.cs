
Console.WriteLine("Bem vindos ao meu primeiro programa em c#");
int idade;
double altura,salario;
char genero;
string nome;

Console.Write("Digite seu nome:");
nome = Console.ReadLine();
Console.Write("Digite sua idade:");
    idade = int.Parse(Console.ReadLine());
Console.Write("Digite sua altura:");
    altura = double.Parse(Console.ReadLine());
Console.Write("Digite seu gênero (M OU F):");
    genero = char.Parse(Console.ReadLine());    
Console.Write("Digite seu salário:");
    salario = double.Parse(Console.ReadLine());
Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos, sua altura é " + altura + " metros, seu gênero é " + genero + " e seu salário é R$ " + salario);
