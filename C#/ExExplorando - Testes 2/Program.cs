using ExemploExplorando.Models;
using Newtonsoft.Json;
using System.Globalization;
using System.Runtime.CompilerServices;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Software", 255.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);

int numero = 20;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par." : "ímpar."));

Pessoa p1 = new Pessoa("Carlos Miguel", "Webber");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");

/////////////////

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine("Quantidade de linhas no arquivo: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo!");
}

/////////////////

(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Carlos Miguel", "Webber", 1.75M);

ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Carlos Miguel", "Webber", 1.75M);
var outroExemploTuplaCreate = Tuple.Create(1, "Carlos Miguel", "Webber", 1.75M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");

/////////////////

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RS", "Rio Grande do Sul");
estados.Add("SC", "Santa Catarina");

Console.WriteLine(estados["SC"]);

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}.");
}

estados.Remove("RS");
estados["SC"] = "Valor Alterado";

Console.WriteLine("--------");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}.");
}

string chave = "SC2";

if (estados.ContainsKey(chave))
{
    Console.WriteLine("Existe!");
}
else
{
    Console.WriteLine("Não existe!");
}

/////////////////

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(5);
pilha.Push(7);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

pilha.Pop();

Console.WriteLine("---------");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}


Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);


foreach (int item in fila)
{
    Console.WriteLine(item);
}

fila.Dequeue();

Console.WriteLine("-----");

foreach (int item in fila)
{
    Console.WriteLine(item);
}

/////////////////

new ExemploExcessao().Metodo1();

/////////////////

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoleitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma execeção 'arquivo não encontrado'. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma execeção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Sempre acontece");
}

/////////////////

string dataString = "2024-12-17 18:00";

bool conversao = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime data);

if (conversao)
{
    Console.WriteLine($"Conversão realizada com sucesso! {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida!");
}

/////////////////

DateTime data = DateTime.Parse("12/04/2024");

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("C4");

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

/////////////////

Pessoa p1 = new Pessoa();
p1.Nome = "carlos";
p1.Sobrenome = "webber";

/////////////////

Pessoa p2 = new Pessoa(nome: "miguel", sobrenome: "model");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

/////////////////

Pessoa p1 = new Pessoa();

p1.Nome = "carlos";
p1.Sobrenome = "webber";
p1.Idade = 18;
p1.Apresentar();