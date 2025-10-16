using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_1_Verivicar_____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cadena con parentesis, corchetes o llaves: ");
            string cadena = Console.ReadLine();

            if (VerificarCadena(cadena))
                Console.WriteLine(" Correcto");
            else
                Console.WriteLine(" Error");

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }

        static bool VerificarCadena(string cadena)
        {
            Stack<char> pila = new Stack<char>();

            for (int i = 0; i < cadena.Length; i++)
            {
                char f = cadena[i];

                // Si es un símbolo de apertura, se inserta en la pila
                if (f == '(' || f == '[' || f == '{')
                {
                    pila.Push(f);
                }
                // Si es de cierre
                else if (f == ')' || f == ']' || f == '}')
                {
                // Si la pila está vacía es igual a error
                    if (pila.Count == 0)
                        return false;

                    char dentro = pila.Pop();

                // Verificar que esten correctos
                    if ((f == ')' && dentro != '(') || (f == ']' && dentro != '[') || (f == '}' && dentro != '{'))
                    {
                        return false;
                    }
                }
            }

            // Si al final la pila está vacía, la cadena es correcta
            return pila.Count == 0;
        
        }
    }
}
