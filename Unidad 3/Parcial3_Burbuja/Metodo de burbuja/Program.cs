using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_de_burbuja
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ORDENAMIENTO BURBUJA ===");

            // Solicitar números al usuario
            int[] numeros = SolicitarNumeros();

            if (numeros.Length == 0)
            {
                Console.WriteLine("No se ingresaron números.");
                return;
            }

            Console.WriteLine($"\nArreglo original: [{string.Join(", ", numeros)}]");

            // Ordenar con burbuja
            Burbuja(numeros);

            Console.WriteLine($"Arreglo ordenado: [{string.Join(", ", numeros)}]");
        }

        static int[] SolicitarNumeros()
        {
            Console.WriteLine("\nIngrese los números separados por espacios:");
            Console.Write("→ ");

            string entrada = Console.ReadLine();
            string[] partes = entrada.Split();

            List<int> numeros = new List<int>();

            foreach (string parte in partes)
            {
                if (int.TryParse(parte, out int numero))
                    numeros.Add(numero);
            }

            return numeros.ToArray();
        }

        static void Burbuja(int[] arreglo)
        {
            int temp;
            bool ordenado;

            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                ordenado = true;

                for (int j = 0; j < arreglo.Length - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        // Intercambiar
                        temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                        ordenado = false;
                    }
                }

                // Si ya está ordenado, terminar
                if (ordenado) break;
            }


            }
    }
}
