using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Area
{
    public abstract class Forms
    {
        public Forms(string name, FormType type)
        {
            Name = name;
            Type = type;
        }

        public string Name2 { get; init; } = string.Empty;

        public double Area => GetArea();

        public abstract double GetArea();

        public string Name { get; set; }

        public FormType Type { get; private set; }

        public virtual void DoSomething()
        {
            Console.WriteLine("hallo");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}