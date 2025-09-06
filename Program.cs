using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DVirtual252
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age = 0;
            bool continueFlag = true;

            Console.WriteLine("Bienvenido al programa, introduce tu nombre");
            name = Console.ReadLine();

            while (continueFlag)
            {
                Console.WriteLine($"Hola {name}, dime tu edad");
                age = int.Parse(Console.ReadLine());
                if (age >= 0)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("Tu edad no puede ser negativa");
                }
            }

            Console.WriteLine($"Veo que tienes {age} años");

        }
    }
}
