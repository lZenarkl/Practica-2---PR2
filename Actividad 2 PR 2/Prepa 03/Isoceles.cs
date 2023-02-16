using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Isoceles : Triangulo
    {
        public Isoceles(double A, double B, double C, string color) : base(A, B, C, color){} 

        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un triangulo Isoceles de color {GetColor()}\nArea: {GetArea()}\nPerimetro: {GetPerimetro()}");
        }
    }
}
