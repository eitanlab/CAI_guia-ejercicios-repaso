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
            string word = "anana";
            string invertedWord = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                invertedWord += word[i];
            }
            if (invertedWord == word)
            {
                Console.WriteLine(word + " es palíndromo");
            } else
            {
                Console.WriteLine(word + " no es palíndromo");
            }
        }
    }
}
