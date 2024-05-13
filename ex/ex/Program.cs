using classeex.Common.Models;

List<string> listaNomes = new List<string>();

listaNomes.Add("Carlos Miguel");
listaNomes.Add("Taísa");
listaNomes.Add("Maria");

foreach (string nome in listaNomes)
{
    Console.WriteLine($"Nome: {nome}");
}

listaNomes.Remove("Maria");

foreach (string nome in listaNomes)
{
    Console.WriteLine($"Nome: {nome}");
}

for (int contador = 0; contador < listaNomes.Count; contador++)
{
    Console.WriteLine($"Nome: {listaNomes[contador]}");
}

int[] arrayInteiros = new int[5];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;
arrayInteiros[3] = 40;
arrayInteiros[4] = 50;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

int contadorForeach = 0;
foreach (int numero in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {numero}");
    contadorForeach++;
}

Person person1 = new Person();

Person pessoa1 = new Person();
pessoa1.Nome = "Carlos Miguel";
pessoa1.Idade = 18;
pessoa1.Apresentar();

bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Listar Clientes");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Sair");

    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastro de Cliente");
            break;
        case 2:
            Console.WriteLine("Listar Clientes");
            break;
        case 3:
            Console.WriteLine("Apagar Cliente");
            break;
        case 4:
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}


int number = 9;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}


Calculadora calculadora = new Calculadora();

Console.WriteLine("Escolha uma operação: ");

Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Potência");

int operacao = Convert.ToInt32(Console.ReadLine());

switch (operacao)
{
    case 1:
        Console.WriteLine("Digite dois números para realizar a soma: ");
        calculadora.Somar(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
        break;

    case 2:
        Console.WriteLine("Digite dois números para realizar a subtração: ");
        calculadora.Subtrair(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
        break;

    case 3:
        Console.WriteLine("Digite dois números para realizar a multiplicação: ");
        calculadora.Multiplicar(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
        break;

    case 4:
        Console.WriteLine("Digite dois números para realizar a divisão: ");
        calculadora.Dividir(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
        break;
    case 5:
        Console.WriteLine("Digite dois números para realizar a potência: ");
        calculadora.Potencia(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
        break;
    default:
        Console.WriteLine("Operação inválida.");
        break;
}

Console.WriteLine("Digite uma letra: ");
string? letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("A letra digitada é uma vogal.");
        break;
    default:
        Console.WriteLine("A letra digitada é uma consoante.");
        break;
}

int quantidadeEmEstoque = 10;
int quantidadeCompra = 5;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    quantidadeEmEstoque -= quantidadeCompra;
    Console.WriteLine($"Venda realizada com sucesso! Quantidade em estoque: {quantidadeEmEstoque}");
}
else
{
    Console.WriteLine("Não foi possível realizar a venda, pois a quantidade em estoque é insuficiente.");
}

string a = "15-";

int b = 0;

int.TryParse(a, out b);

tring number = "150";

int numberInt = Convert.ToInt32(number);

Console.WriteLine(numberInt);

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

string apresentacao = "Olá, seja bem vindo";

int quantidade = 50;

double altura = 1.80;

decimal preco = 10.50M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("O valor da variável quantidade é: " + quantidade);
Console.WriteLine("O valor da variável altura é: " + altura);
Console.WriteLine("O valor da variável preco é: " + preco);
Console.WriteLine("O valor da variável condicao é: " + condicao);

Person person1 = new Person();

person1.Nome = "Carlos Miguel";

person1.Idade = 18;

person1.Apresentar();
