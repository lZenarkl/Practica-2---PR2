using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Rectangulo: Figura
    {
        private double _base;
        private double _altura;
        public Rectangulo(double base_rectangulo, double altura, string color) : base(color)
        {
            _base = base_rectangulo;
            _altura = altura;

        }
        public override double GetArea()
        {
            return _base * _altura;
        }
        public override double GetPerimetro()
        {
            return (2 * _base) + (2 * _altura);
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un Rectangulo de Color {GetColor()}\nArea: {GetArea()}\nPerimetro: {GetPerimetro()}");
        }
    }
}
