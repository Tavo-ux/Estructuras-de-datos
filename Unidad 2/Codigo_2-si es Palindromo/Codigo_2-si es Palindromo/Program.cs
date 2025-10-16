using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_2_si_es_Palindromo
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Ingrese una palabra :");
            String Cadena = Console.ReadLine(); 

            if (InvertirCadena(Cadena)) 
            {
                Console.WriteLine("La palabra es un palindromo");
            }
            else
            {
                Console.WriteLine("La palabra no es un palindromo");
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }

        static bool InvertirCadena(string Cadena)
        {  
           string CadenaNueva = "";
           Stack<char> Pila = new Stack<char>();

            for(int i = 0; i < Cadena.Length; i++)
            {
                char c = Cadena[i];
                Pila.Push(c);
            }

            while (Pila.Count > 0)
            {
                char C = Pila.Pop();
                CadenaNueva += C;
            }

            if (CadenaNueva.Equals(Cadena))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
