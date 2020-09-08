using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord;
            string secondWord;
            Console.Write("Ingresá la primer palabra:");
            firstWord = Console.ReadLine();
            Console.Write("Ingresá la segunda palabra:");
            secondWord = Console.ReadLine();
            if (firstWord != "" && secondWord != "")
            {
                if (firstWord.Length == secondWord.Length)
                {
                    for (int i = 0; i < firstWord.Length; i++)
                    {
                        for (int j = 0; j < secondWord.Length; j++)
                        {
                            if (firstWord[i] == secondWord[j])
                            {
                                secondWord = secondWord.Remove(j, 1);
                            }
                        }
                    }
                    if (secondWord.Length == 0)
                    {
                        Console.WriteLine("Las palabras ingresadas son anagramas");
                    }
                    else
                    {
                        Console.WriteLine("Las palabras ingresadas NO son anagramas");
                    }
                } else
                {
                    Console.WriteLine("Las palabras ingresadas NO son anagramas");
                }
                    
            }
            else
            {
                Console.WriteLine("No se han ingresado palabras a comprobar");
            }
        }
    }
}
