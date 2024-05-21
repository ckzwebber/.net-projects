using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public bool EhPar(int n3)
        {
            return n3 % 2 == 0;
        }
    }
}