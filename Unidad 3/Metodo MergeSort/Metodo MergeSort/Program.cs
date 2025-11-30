using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ALGORITMO MERGE SORT");
            Console.WriteLine("====================");

            // Solicitar al usuario que ingrese los números
            Console.WriteLine("Ingrese los números separados por espacios:");
            string input = Console.ReadLine();

            // Convertir la entrada en un arreglo de enteros
            string[] numerosStr = input.Split(' ');
            int[] arreglo = new int[numerosStr.Length];

            for (int i = 0; i < numerosStr.Length; i++)
            {
                if (int.TryParse(numerosStr[i], out int numero))
                {
                    arreglo[i] = numero;
                }
                else
                {
                    Console.WriteLine($"Error: '{numerosStr[i]}' no es un número válido. Se usará 0 en su lugar.");
                    arreglo[i] = 0;
                }
            }

            // Mostrar arreglo original
            Console.WriteLine("\nArreglo original:");
            MostrarArreglo(arreglo);

            // Aplicar Merge Sort
            int[] arregloOrdenado = MergeSort(arreglo);

            // Mostrar resultado
            Console.WriteLine("\nArreglo ordenado:");
            MostrarArreglo(arregloOrdenado);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Función principal de Merge Sort
        static int[] MergeSort(int[] arreglo)
        {
            // Caso base: si el arreglo tiene 0 o 1 elemento, ya está ordenado
            if (arreglo.Length <= 1)
            {
                return arreglo;
            }

            // Dividir el arreglo en dos mitades
            int mitad = arreglo.Length / 2;

            int[] izquierda = new int[mitad];
            int[] derecha = new int[arreglo.Length - mitad];

            // Copiar elementos a la mitad izquierda
            for (int i = 0; i < mitad; i++)
            {
                izquierda[i] = arreglo[i];
            }

            // Copiar elementos a la mitad derecha
            for (int i = mitad; i < arreglo.Length; i++)
            {
                derecha[i - mitad] = arreglo[i];
            }

            // Llamadas recursivas
            int[] izquierdaMs = MergeSort(izquierda);
            int[] derechaMs = MergeSort(derecha);

            // Unir las mitades ordenadas
            return Union(izquierdaMs, derechaMs);
        }

        // Función para unir dos arreglos ordenados
        static int[] Union(int[] izquierda, int[] derecha)
        {
            int[] resultado = new int[izquierda.Length + derecha.Length];
            int i = 0, j = 0, k = 0;

            // Comparar elementos de ambos arreglos y agregar el menor
            while (i < izquierda.Length && j < derecha.Length)
            {
                if (izquierda[i] <= derecha[j])
                {
                    resultado[k] = izquierda[i];
                    i++;
                }
                else
                {
                    resultado[k] = derecha[j];
                    j++;
                }
                k++;
            }

            // Agregar los elementos restantes del arreglo izquierdo
            while (i < izquierda.Length)
            {
                resultado[k] = izquierda[i];
                i++;
                k++;
            }

            // Agregar los elementos restantes del arreglo derecho
            while (j < derecha.Length)
            {
                resultado[k] = derecha[j];
                j++;
                k++;
            }

            return resultado;
        }

        // Función para mostrar un arreglo
        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int num in arreglo)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
