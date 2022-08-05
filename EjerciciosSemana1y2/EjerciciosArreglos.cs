using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSemana1y2
{
    internal class EjerciciosArreglos
    {
        public void Menu()
        {
            Console.WriteLine("Se encuentra en el menú de arreglos. Digite el punto que desea ver:");
            Console.WriteLine("1. Primer Punto");
            Console.WriteLine("2. Segundo Punto");
            Console.WriteLine("3. Tercer Punto");
            int opc=int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    PrimerPunto();
                    break;
                case 2:
                    SegundoPunto();
                    break;
                case 3:
                    TercerPunto();
                    break;
                default:
                    break;
            }
        }
        static void PrimerPunto()
        {
            int[] numero_alumnos = new int[4];
            int[] parcial = new int[4];
            int[] oral = new int[4];
            int[] final = new int[4];
            string[] nombre_alumnos = new string[4];
            int[] promedio = new int[4];
            for (int i = 0; i < numero_alumnos.Length; i++)
            {
                Console.WriteLine("Introduzca el nombre del {0}º alumno", i + 1);
                nombre_alumnos[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del Examen Parcial:");
                parcial[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota del Examen Oral:");
                oral[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota del Examen Final:");
                final[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                for (int a = 0; a < promedio.Length; a++)
                {
                    promedio[a] = (parcial[a] + oral[a] + final[a]) / 3;
                }
            }

            for (int b = 0; b < numero_alumnos.Length; b++)
            {
                Console.WriteLine($"Nombre: {nombre_alumnos[b]}\n Examen parcial: {parcial[b]}\n Examen oral: {oral[b]}\n Examen final: {final[b]}\n Promedio: {promedio[b]}");
                if (promedio[b] >= 7)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("No Aprobado");
                }
            }
        }

        static void SegundoPunto()
        {
            string[] nombre = new string[5];
            string[] apellido = new string[5];
            int[] edad = new int[5];
            string[] sexo = new string[5];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"Introduzca el nombre del empleado {i + 1}");
                nombre[i] = Console.ReadLine();
                Console.WriteLine($"Introduzca el apellido del empleado ");
                apellido[i] = Console.ReadLine();
                Console.WriteLine($"Introduzca la edad del empleado");
                edad[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Introduzca el sexo del empleado");
                sexo[i] = Console.ReadLine();
                Console.WriteLine("<=======================================================>");
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"Datos empleado {i + 1} \n Nombre : {nombre[i]} \n Apellidos :{apellido[i]} \n Edad : {edad[i]} \n Sexo: {sexo[i]} ");
                Console.WriteLine("<=======================================================>");
            }
        }

        static void TercerPunto()
        {
            int totalPago = 0;
            Console.WriteLine("Digite la cantidad de productos que quiere ingresar ");
            int cantidadProd = int.Parse(Console.ReadLine());
            int[] precios = new int[cantidadProd];

            for (int i = 0; i < precios.Length; i++)
            {
                Console.Write("Digite el precio del producto " + (i + 1) + "\n$");
                precios[i] = int.Parse(Console.ReadLine());
                totalPago = precios[i] + totalPago;
                Console.WriteLine("<=======================================================>");
            }
            Console.WriteLine("Valor total a pagar = $" + totalPago);
        }
    }
}
