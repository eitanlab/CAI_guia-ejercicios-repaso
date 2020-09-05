using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.Ej1
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
                    case var n when i % 3 == 0 & i % 5 == 0:
                        Console.WriteLine(i + " - FooBar");
                        break;
                    case var n when i % 3 == 0:
                        Console.WriteLine(i + " - Foo");
                        break;
                    case var n when i % 5 == 0:
                        Console.WriteLine(i + " - Bar");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }
    }
}
