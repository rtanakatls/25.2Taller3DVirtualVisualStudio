using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DVirtual252.Shape
{
    internal class Circle : Shape
    {
        protected float radius;
        private float pi = 3.1416f;

        public Circle(float radius) : base("Círculo")
        {
            this.radius = radius;
        }

        public override float GetArea()
        {
            return pi * radius * radius;
        }
    }
}
