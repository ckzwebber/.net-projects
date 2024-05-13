using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Professor : Pessoa
    {

        public Professor(string nome) : base(nome)
        {

        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Salario: {Salario}");
        }
    }
}