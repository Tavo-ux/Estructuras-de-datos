using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_recursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULO DE FACTORIALES ===");
            Console.WriteLine("Ingrese los números separados por comas (ejemplo: 4,5,3,9,7):");

            string input = Console.ReadLine();

            // Convertir entrada en arreglo de números
            int[] numbers = ParseInput(input);

            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Entrada no válida. Saliendo del programa.");
                return;
            }

            Console.WriteLine("\nResultados:");
            Console.WriteLine("-----------");

            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    Console.WriteLine($"Factorial de {num}: No definido para números negativos");
                    continue;
                }

                try
                {
                    long factRecursivo = FactConRecursion(num);
                    long factIterativo = FactSinRecursion(num);

                    Console.WriteLine($"Factorial de {num}:");
                    Console.WriteLine($"  Con recursión: {factRecursivo}");
                    Console.WriteLine($"  Sin recursión: {factIterativo}");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error calculando factorial de {num}: {ex.Message}");
                }
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método CON recursión (primer diagrama)
        static long FactConRecursion(int x)
        {
            if (x == 0 || x == 1)
                return 1;

            return x * FactConRecursion(x - 1);
        }

        // Método SIN recursión (segundo diagrama)
        static long FactSinRecursion(int n)
        {
            long resultado = 1;

            for (int i = 2; i <= n; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }

        // Método para procesar la entrada del usuario
        static int[] ParseInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new int[0];

            try
            {
                string[] parts = input.Split(',');
                List<int> numbers = new List<int>();

                foreach (string part in parts)
                {
                    if (int.TryParse(part.Trim(), out int number))
                    {
                        numbers.Add(number);
                    }
                }

                return numbers.ToArray();
            }
            catch
            {
                return new int[0];
            }
        }
    }
}
