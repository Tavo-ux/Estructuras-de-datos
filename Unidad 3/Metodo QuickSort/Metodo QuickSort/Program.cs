using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo QuickSort en C#");
            Console.WriteLine("=========================\n");

            int[] arreglo = IngresarArreglo();

            Console.WriteLine("\nArreglo original:");
            ImprimirArreglo(arreglo);

            QuickSort(arreglo, 0, arreglo.Length - 1);

            Console.WriteLine("\nArreglo ordenado:");
            ImprimirArreglo(arreglo);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static int[] IngresarArreglo()
        {
            Console.WriteLine("Ingresa los números separados por comas o espacios:");
            Console.WriteLine("Ejemplo: 64, 34, 25, 12, 22, 11, 90, 5");
            Console.Write("→ ");

            string input = Console.ReadLine();

            // Separar por comas o espacios y convertir a números
            string[] numeros = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] arreglo = new int[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (int.TryParse(numeros[i], out int numero))
                {
                    arreglo[i] = numero;
                }
                else
                {
                    Console.WriteLine($"⚠️  '{numeros[i]}' no es un número válido. Se usará 0 en su lugar.");
                    arreglo[i] = 0;
                }
            }

            return arreglo;
        }

        static void QuickSort(int[] arreglo, int comienzo, int final)
        {
            if (comienzo < final)
            {
                int pivot = Particion(arreglo, comienzo, final);
                QuickSort(arreglo, comienzo, pivot - 1);
                QuickSort(arreglo, pivot + 1, final);
            }
        }

        static int Particion(int[] arreglo, int comienzo, int final)
        {
            int pivot = arreglo[final];
            int i = comienzo - 1;

            for (int j = comienzo; j < final; j++)
            {
                if (arreglo[j] <= pivot)
                {
                    i++;
                    // Intercambiar elementos
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                }
            }

            // Colocar el pivote en su posición correcta
            int aux = arreglo[i + 1];
            arreglo[i + 1] = arreglo[final];
            arreglo[final] = aux;

            return i + 1;
        }

        static void ImprimirArreglo(int[] arreglo)
        {
            Console.Write("[");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]);
                if (i < arreglo.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}
