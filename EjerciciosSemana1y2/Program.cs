using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana1y2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            EjerciciosMetodos metodos = new EjerciciosMetodos();
            EjerciciosArreglos arreglos = new EjerciciosArreglos();
            int opc = 0;
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Digite el punto que desea ver:");
                Console.WriteLine("1. Arreglos:");                
                Console.WriteLine("2. Metodos:");
                Console.WriteLine("3. Clases:");
                Console.WriteLine("0. Para salir");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        arreglos.Menu();
                        break;

                    case 2:
                        metodos.Menu();
                        break;

                    case 3:
                        
                        break;

                    case 0:
                        Console.WriteLine("Saliendo");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opc != 0);

        }

        
    }
}
