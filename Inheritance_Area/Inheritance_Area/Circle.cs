using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Area
{
    public sealed class Circle : Forms
    {
        public Circle(double radius, string name) : base(name, FormType.Circle)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}