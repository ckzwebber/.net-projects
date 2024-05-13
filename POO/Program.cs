using POO.Interfaces;
using POO.Models;

ICalculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Somar(10, 20));

Computador c = new Computador();


Aluno a1 = new Aluno("Carlos");

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();


Aluno a1 = new Aluno();
a1.Nome = "Carlos";
a1.Idade = 30;
a1.Email = "test@gmail.com";
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Miguel";
p1.Idade = 30;
p1.Salario = 3000;
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(3000);
c1.ExibirSaldo();

Pessoa p1 = new Pessoa();
p1.Nome = "Carlos";
p1.Idade = 30;

p1.Apresentar();
