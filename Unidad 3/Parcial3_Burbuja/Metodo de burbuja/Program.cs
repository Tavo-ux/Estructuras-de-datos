using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_de_burbuja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ALGORITMO DE ORDENAMIENTO BURBUJA ===");
            Console.WriteLine("Ingrese los números manualmente para ordenar\n");

            IngresarYOrdenarArray();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // MÉTODO BURBUJA CORREGIDO
        static void Burbuja(int[] arreglo)
        {
            Console.WriteLine("\n--- INICIANDO ORDENAMIENTO BURBUJA ---");

            // Paso 1: Inicialización
            int k = arreglo.Length - 1;
            bool cambio = true;
            int iteraciones = 0;

            Console.WriteLine($"Array a ordenar: [{string.Join(", ", arreglo)}]");
            Console.WriteLine($"Tamaño del array: {arreglo.Length}");
            Console.WriteLine($"K inicial: {k}");

            // Paso 2: Bucle externo
            while (cambio)
            {
                iteraciones++;
                cambio = false;

                Console.WriteLine($"\n--- Iteración #{iteraciones} (comparando {k} elementos) ---");

                // Paso 3: Bucle interno
                for (int j = 0; j < k; j++)
                {
                    bool esMayor = arreglo[j] > arreglo[j + 1];
                    Console.Write($"  [{j}]:{arreglo[j]} > [{j + 1}]:{arreglo[j + 1]} = {esMayor}");

                    if (esMayor)
                    {
                        // Paso 4: Intercambio
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                        cambio = true;

                        Console.WriteLine(" ✓ INTERCAMBIO");
                        Console.WriteLine($"    Array actual: [{string.Join(", ", arreglo)}]");
                    }
                    else
                    {
                        Console.WriteLine(" - NO intercambia");
                    }
                }

                // Reducir K para optimizar
                k--;
            }

            Console.WriteLine($"\n--- ORDENAMIENTO COMPLETADO ---");
            Console.WriteLine($"Total de iteraciones: {iteraciones}");
        }

        static void IngresarYOrdenarArray()
        {
            Console.WriteLine("Ingrese los números separados por comas (ej: 5,2,8,1,9):");
            Console.Write(">> ");

            string input = Console.ReadLine();

            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: No se ingresaron números.");
                    return;
                }

                // Convertir input a array de números
                int[] arreglo = input.Split(',')
                    .Select(x => int.Parse(x.Trim()))
                    .ToArray();

                if (arreglo.Length == 0)
                {
                    Console.WriteLine("Error: El array está vacío.");
                    return;
                }

                Console.WriteLine($"\n✅ Array ingresado correctamente:");
                Console.WriteLine($"[{string.Join(", ", arreglo)}]");

                // Aplicar algoritmo de burbuja
                Burbuja(arreglo);

                // Mostrar resultado final
                Console.WriteLine($"\n🎯 RESULTADO FINAL ORDENADO:");
                Console.WriteLine($"[{string.Join(", ", arreglo)}]");

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Asegúrese de ingresar solo números separados por comas.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
