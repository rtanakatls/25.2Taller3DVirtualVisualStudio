using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DVirtual252.Shape
{
    internal class ShapeMenu
    {

        private List<Shape> shapes;

        public ShapeMenu()
        {
            shapes = new List<Shape>();
        }

        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag = true;

            while(continueFlag)
            {
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1. Crear rectángulo");
                Console.WriteLine("2. Crear cuadrado");
                Console.WriteLine("3. Crear círculo");
                Console.WriteLine("4. Crear triángulo");
                Console.WriteLine("5. Mostrar todas las figuras");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        AddRectangle();
                        break;
                    case "2":
                        AddSquare();
                        break;
                    case "3":
                        AddCircle();
                        break;
                    case "4":
                        AddTriangle();
                        break;
                    case "5":
                        ShowShapes();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void AddRectangle()
        {
            Console.WriteLine("Introduce la base del rectángulo:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del rectángulo:");
            float h = float.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(b, h));
        }

        private void AddSquare()
        {
            Console.WriteLine("Introduce el lado del cuadrado:");
            float s = float.Parse(Console.ReadLine());
            shapes.Add(new Square(s));
        }

        private void AddCircle()
        {
            Console.WriteLine("Introduce el radio del círculo:");
            float radius = float.Parse(Console.ReadLine());
            shapes.Add(new Circle(radius));
        }

        private void AddTriangle()
        {
            Console.WriteLine("Introduce la base del triángulo:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triángulo:");
            float h = float.Parse(Console.ReadLine());
            shapes.Add(new Triangle(b, h));
        }

        private void ShowShapes()
        {
            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"Figura: {shape.Name} - Área: {shape.GetArea()}");
            }
        }
    }
}
