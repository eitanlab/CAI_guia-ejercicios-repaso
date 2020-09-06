using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            string invertedWord = "";
            Console.Write("Ingresá la palabra:");
            word = Console.ReadLine();
            if (word != "")
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    invertedWord += word[i];
                }
                if (invertedWord == word)
                {
                    Console.WriteLine(word + " es palíndromo");
                }
                else
                {
                    Console.WriteLine(word + " no es palíndromo");
                }
            } else
            {
                Console.WriteLine("no se ha ingresado una palabra a comprobar");
            }
        }
    }
}
