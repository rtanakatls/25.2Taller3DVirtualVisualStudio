using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DVirtual252.Shape
{
    internal class Rectangle : Shape
    {
        protected float b;
        protected float h;

        public Rectangle(float b, float h) : base("Rectángulo")
        {
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return b * h;
        }

    }
}
