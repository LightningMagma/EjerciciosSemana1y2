using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana1y2
{
    internal class EjerciciosMetodos
    {
        public void Menu()
        {
            Console.WriteLine("Se encuentra en el menú de Metodos. Digite el punto que desea ver:");
            Console.WriteLine("1. Primer Punto");
            Console.WriteLine("2. Segundo Punto");
            Console.WriteLine("3. Tercer Punto");
            Console.WriteLine("4. Cuarto Punto");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    primerMetodo();
                    break;
                case 2:
                    SegundoMetodo();
                    break;
                case 3:
                    TercerMetodo();
                    break;
                case 4:
                    CuartoMetodo();
                    break;
                default:
                    break;
            }
        }
        static void primerMetodo()
        {
            double euro = 4522.04;
            double dolar = 4429.64;
            double yen = 32.73;
            double rublo = 73.92;
            double real = 844.71;

            Console.WriteLine("Digite la moneda que desea convertir:\n 1.Euro\n 2.Dólar\n 3.Yen\n 4.Rublo\n 5.Real");
            string opc = Console.ReadLine();
            Console.WriteLine("Digite la cantidad de dinero");
            double dinero = double.Parse(Console.ReadLine());
            double conversion = 0;
            switch (opc)
            {
                case "1":
                    conversion = dinero * euro;
                    Console.WriteLine($"Cantidad Dinero en US$ {dinero}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;
                case "2":
                    conversion = dinero * dolar;
                    Console.WriteLine($"Cantidad Dinero en R$ {dinero}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;
                case "3":
                    conversion = dinero * yen;
                    Console.WriteLine($"Cantidad Dinero en ₽ {dinero}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;
                case "4":
                    conversion = dinero * rublo;
                    Console.WriteLine($"Cantidad Dinero en € {dinero}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;
                case "5":
                    conversion = dinero * real;
                    Console.WriteLine($"Cantidad Dinero en ¥ {dinero}");
                    Console.WriteLine($"Cantidad Dinero en COP$ {conversion}");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }

        static void SegundoMetodo()
        {
            double lado_1 = 0;
            double lado_2 = 0;
            Console.WriteLine("Ingrese el valor del primer lado del rectángulo:");
            lado_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del primer lado del rectángulo:");
            lado_2 = double.Parse(Console.ReadLine());
            double area = lado_1 * lado_2;
            Console.WriteLine($"El área de su rectangulo es de: {area}");
        }

        static void TercerMetodo()
        {
            try
            {
                int edad = 0;
                Console.WriteLine("Digite su edad ");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad < 18)
                {
                    Console.WriteLine("Usted es menor de edad");
                }
                else if (edad < 60)
                {
                    Console.WriteLine("Usted es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Usted es persona adulto mayor");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error caracter no valido");
            }

        }

        static void CuartoMetodo()
        {
            int numero = 0;
            int resultado = 0;
            Console.WriteLine("Digite la tabla de multiplicar que desea");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
            }
        }
    }
}
