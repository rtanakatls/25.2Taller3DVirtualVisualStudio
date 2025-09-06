using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DVirtual252
{
    internal class Menu
    {
        public void Execute()
        {
            Console.WriteLine("Bienvenido al programa");

            Person person = CreatePerson();
            Console.WriteLine($"Hola {person.Name}, tienes {person.Age} años");
        }

        private Person CreatePerson()
        {
            string name;
            int age = 0;
            bool continueFlag = true;
            Console.WriteLine("Introduce tu nombre");
            name = Console.ReadLine();

            while (continueFlag)
            {
                Console.WriteLine("Introduce tu edad");
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
            return new Person(name, age);
        }
    }
}
