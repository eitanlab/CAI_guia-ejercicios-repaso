using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int regNumber = 864;
            for (int i = 1; i <= regNumber; i++)
            {
                switch (i)
                {
                    case var n when isPrime(n) & isMultiplier(n,3):
                        Console.WriteLine(i + " - Es primo y divisible por 3");
                        break;
                    case var n when isMultiplier(n, 3):
                        Console.WriteLine(i + " - Es divisible por 3");
                        break;
                    case var n when isPrime(n):
                        Console.WriteLine(i + " - Es primo");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }

        static bool isPrime(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            return true;
        }

        static bool isMultiplier(int number, int divisor)
        {
            if (number % divisor == 0)
            {
                return true;
            }
            return false;
        }
    }
}
