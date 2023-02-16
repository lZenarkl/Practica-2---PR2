using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Equilatero : Triangulo
    {
        public Equilatero(double A, double B, double C, string color) : base(A, B, C,color){ } //esto esta permitido? me parecio mas agradable a la vista asi

        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un triangulo Equilatero de color {GetColor()}\nArea: {GetArea()}\nPerimetro: {GetPerimetro()}");
        }
    }
}
