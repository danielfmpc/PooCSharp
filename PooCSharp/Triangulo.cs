using System;
using System.Collections.Generic;
using System.Text;

namespace PooCSharp
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double CalculaAreaTriangulo()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return raiz;
        }
    }
}
