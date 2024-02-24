using Inheritance_Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class MyList<T>
        where T : Forms
    {
        public int Count { get; private set; }

        private class Data
        {
            public Data(T value)
            {
                Value = value;
            }

            public T Value { get; set; }
            public Data? Next { get; set; }
        }

        private Data? Head { get; set; }
        private Data? Last { get; set; }

        public void Add(T data)
        {
            if (Head == null)
            {
                Head = new Data(data);
                Last = Head;
            }
            else
            {
                Head.Next = new Data(data);

                Head = Head.Next;
            }
            Console.WriteLine("Added: " + data.Area);
            Count++;
        }

        public T? ElementAt(int index)
        {
            if (Head == null)
                return default;

            if (index < 0 || index >= Count)
                return default;

            if (index == Count - 1)
                return Head.Value;

            var result = Last;

            for (int i = 0; i < index; i++)
            {
                if (result != null)
                    result = result.Next;
            }

            return result != null ? result.Value : default;
        }
    }
}