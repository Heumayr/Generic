using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Area
{
    public sealed class Square : Forms
    {
        public Square(double length, string name) : base(name, FormType.Square)
        {
        }

        public override void DoSomething()
        {
            Console.WriteLine("welt");
        }

        public double Length { get; set; }

        public override double GetArea()
        {
            return Length * Length;
        }
    }
}