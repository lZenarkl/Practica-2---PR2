﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Cuadrado: Rectangulo
    {
        public Cuadrado(double lado, string color) : base (lado, lado, color) {}

        public override void MostrarDatos()
        {
            Console.WriteLine($"Soy un Cuadrado de Color {GetColor()}\nArea: {GetArea()}\nPerimetro: {GetPerimetro()}");
        }
    }
}
