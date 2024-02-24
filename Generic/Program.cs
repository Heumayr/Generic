using Inheritance_Area;

namespace Generic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //    var myList = new MyList<int>();

            //    myList.Add(5);
            //    myList.Add(10);
            //    myList.Add(15);
            //    myList.Add(20);

            //    Console.WriteLine(myList.ElementAt(0));

            //    var myList2 = new MyList<string>();

            //    myList2.Add("Richard");
            //    myList2.Add("Franz");
            //    myList2.Add("Andi");

            var mylist3 = new MyList<Forms>();

            var circle = new Circle(4, "Circle A");

            var rectangle = new Rectangle(10, 5, "Rect A");

            var square = new Square(3, "Square A")
            {
                Name2 = "Name 2"
            };

            mylist3.Add(circle);
            mylist3.Add(rectangle);
            mylist3.Add(square);

            Console.WriteLine(mylist3.ElementAt(1));
        }
    }
}