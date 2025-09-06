using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DVirtual252.Shape
{
    internal class Triangle : Shape
    {
        protected float b;
        protected float h;

        public Triangle(float b, float h) : base("Triángulo")
        {
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return (b * h) / 2;
        }

    }
}
