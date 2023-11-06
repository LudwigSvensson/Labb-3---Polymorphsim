namespace Labb_3___Polymorphsim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();            
            Geometry square = new Square();            
            Geometry rectangle = new Rectangle();            
            Geometry triangle = new Triangle();

            Console.WriteLine($"Area of the circle is: {circle.Area()}" +
                $"\nArea of the square is: {square.Area()}" +
                $"\nArea of the rectangle is: {rectangle.Area()}" +
                $"\nArea of the rectangle is: {triangle.Area()}");
        }
    }
}