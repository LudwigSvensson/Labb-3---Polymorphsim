namespace Labb_3___Polymorphsim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(7.42);            
            Square square = new Square(6.30);            
            Rectangle rectangle = new Rectangle(5.5,9.3);            
            Triangle triangle = new Triangle(2.4,10,9.4);
            Console.WriteLine($"Area of the circle is: {circle.Area()}" +
                $"\nArea of the square is: {square.Area()}" +
                $"\nArea of the rectangle is: {rectangle.Area()}" +
                $"\nArea of the rectangle is: {triangle.Area()}");

        }
    }
}