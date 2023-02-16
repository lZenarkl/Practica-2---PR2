using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Triangulo : Figura
    {
        private double ladoA, ladoB, ladoC;

        public Triangulo(double A, double B, double C, string color) : base(color)
        {
            ladoA = A;
            ladoB = B;
            ladoC = C;
        }

        public double Semiperimetro()
        {
            return (ladoA + ladoB + ladoC) / 2;
        }

        public override double GetPerimetro()
        {
            return ladoA + ladoB + ladoC;
        }
        public override double GetArea()
        {
            return Math.Sqrt(Semiperimetro() * (Semiperimetro() - ladoA) * (Semiperimetro() - ladoB) * (Semiperimetro() - ladoC)); //formula de Herón
        }
    }
}
