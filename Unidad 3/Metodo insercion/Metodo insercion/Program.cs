using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_insercion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ALGORITMO DE ORDENAMIENTO POR INSERCIÓN");
            Console.WriteLine("=======================================\n");

            // Solicitar los elementos del arreglo en formato secuencial
            Console.WriteLine("Ingrese los elementos del arreglo separados por comas (ejemplo: 4,5,6,8,9):");
            string entrada = Console.ReadLine();

            // Convertir la entrada en un arreglo de enteros
            int[] arreglo = entrada.Split(',')
                                  .Select(elemento => int.Parse(elemento.Trim()))
                                  .ToArray();

            // Mostrar el arreglo original
            Console.WriteLine("\nArreglo original:");
            MostrarArreglo(arreglo);

            // Aplicar el algoritmo de inserción
            OrdenamientoInsercion(arreglo);

            // Mostrar el arreglo ordenado
            Console.WriteLine("\nArreglo ordenado:");
            MostrarArreglo(arreglo);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void OrdenamientoInsercion(int[] arreglo)
        {
            Console.WriteLine("\nProceso de ordenamiento:");

            for (int j = 1; j < arreglo.Length; j++)
            {
                int temp = arreglo[j];
                int i = j - 1;

                // Mover los elementos mayores que temp hacia la derecha
                while (i >= 0 && arreglo[i] > temp)
                {
                    arreglo[i + 1] = arreglo[i];
                    i--;
                }

                // Insertar temp en la posición correcta
                arreglo[i + 1] = temp;

                // Mostrar el estado actual del arreglo
                Console.Write($"Paso {j}: ");
                MostrarArreglo(arreglo);
            }
        }

        static void MostrarArreglo(int[] arreglo)
        {
            Console.WriteLine("[" + string.Join(", ", arreglo) + "]");
        }
    }
}
