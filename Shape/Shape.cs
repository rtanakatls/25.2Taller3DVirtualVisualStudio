﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DVirtual252.Shape
{
    internal class Shape
    {
        protected string name;

        public string Name { get { return name; } }

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual float GetArea()
        {
            return 0;
        }   
    }
}
