using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp;
            string pintura;

            do {
                Console.WriteLine("Seleccione una fgura: ");
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Rectangulo");
                Console.WriteLine("4. Triangulo");
                Console.WriteLine("0. Salir");

                Console.Write("Respuesta: ");
                resp = Convert.ToInt32(Console.ReadLine());

                switch (resp)
                {
                    case 1:
                        double radio;
                        Console.Write("Ingrese el radio del circulo: ");
                        radio = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese un color para su figura: ");
                        pintura = Console.ReadLine();

                        Circulo figura = new Circulo(radio, pintura);
                        figura.MostrarDatos();
                        break;

                    case 2:
                        double _Lado;
                        Console.Write("Ingrese la medida del cuadrado: ");
                        _Lado = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese un color para su figura: ");
                        pintura = Console.ReadLine();

                        Rectangulo figura2 = new Cuadrado(_Lado, pintura);
                        figura2.MostrarDatos();
                        break;

                    case 3:
                        double altura;
                        Console.Write("Ingrese la base del rectangulo: ");
                        _Lado = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese la altura del rectangulo: ");
                        altura = double.Parse(Console.ReadLine());

                        Console.Write("Ingrese un color para su figura: ");
                        pintura = Console.ReadLine();

                        Rectangulo figura3 = new Rectangulo(_Lado, altura, pintura);
                        figura3.MostrarDatos();
                        break;

                    case 4:
                        double lado1, lado2, lado3;
                        Console.Write("Lado 1 del triagulo: ");
                        lado1 = double.Parse(Console.ReadLine());

                        Console.Write("Lado 2 del triagulo: ");
                        lado2 = double.Parse(Console.ReadLine());

                        Console.Write("Lado 3 del triagulo: ");
                        lado3 = double.Parse(Console.ReadLine());

                        double discriminante = (lado1 + lado2 + lado3) / 2;
                        if (lado1 < discriminante && lado2 < discriminante && lado3 < discriminante) //tuve que colocar esto porque dentro de la                                                                                                   
                        {                                                                            //formula habian casos donde aparecian raices negativas
                            Console.Write("Ingrese un color para su figura: ");                      //y ya me estaba viendo venir que colocarian numeros random
                            pintura = Console.ReadLine();

                            if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                            {
                                Triangulo figura4_1 = new Equilatero(lado1, lado2, lado3, pintura);
                                figura4_1.MostrarDatos();
                            }
                            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                            {
                                Triangulo figura4_2 = new Isoceles(lado1, lado2, lado3, pintura);
                                figura4_2.MostrarDatos();
                            }
                            else
                            {
                                Triangulo figura4_3 = new Escaleno(lado1, lado2, lado3, pintura);
                                figura4_3.MostrarDatos();
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Por favor ingresa un triangulo coherente");
                            break;
                        }   
                }
                Console.ReadKey();
                Console.Clear();  
            } while (resp != 0);
            //para un poco mas de orden, acomode el codigo como un menu
            Console.ReadLine();
        }
    }
}
