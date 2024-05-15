using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classeex.Common.Models
{
    public class Calculadora
    {
        public void Somar(double x, double y)
        {
            Console.WriteLine($"A soma de {x} + {y} é = {x + y}");
        }

        public void Subtrair(double x, double y)
        {
            Console.WriteLine($"A subtração de {x} - {y} é = {x - y}");
        }

        public void Multiplicar(double x, double y)
        {
            Console.WriteLine($"A multiplicação de {x} * {y} é = {x * y}");
        }

        public void Dividir(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                Console.WriteLine($"A divisão de {x} / {y} é = {x / y}");
            }
        }

        public void Potencia(double x, double y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"A potência de {x} ^ {y} é = {pot}");
        }
    }
}