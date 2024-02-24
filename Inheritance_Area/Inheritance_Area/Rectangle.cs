using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Area
{
    public sealed class Rectangle : Forms
    {
        public Rectangle(double length, double width, string name) : base(name, FormType.Rectangle)
        {
            Width = width;
            Length = length;
        }

        public double Length { get; set; }

        public double Width { get; set; }

        public override double GetArea()
        {
            return Length * Width;
        }
    }
}