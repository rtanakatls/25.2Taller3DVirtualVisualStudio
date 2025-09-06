using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DVirtual252.Shape
{
    internal class ShapeMenu
    {
        public void Execute()
        {
            List<Shape> shapes = new List<Shape>(); 
            shapes.Add(new Triangle(3, 4));
            shapes.Add(new Rectangle(3, 4));
            shapes.Add(new Triangle(30, 24));
            shapes.Add(new Rectangle(30, 42));

            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Name} - {shape.GetArea()}");
            }

        }
    }
}
