namespace Inheritance_Area
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var circle = new Circle(4, "Circle A");

            var rectangle = new Rectangle(10, 5, "Rect A");

            var square = new Square(3, "Square A")
            {
                Name2 = "Name 2"
            };

            var list = new List<Forms>();

            list.Add(circle);
            list.Add(rectangle);
            list.Add(square);

            //var sumArea = 0.0;

            //foreach (Forms form in list)
            //{
            //    Console.WriteLine("Area " + form + " " + form.Area);
            //    sumArea += form.Area;
            //}

            //Console.WriteLine("sum: " + sumArea);

            foreach (Forms form in list)
            {
                Console.WriteLine((int)form.Type);
            }
        }
    }
}