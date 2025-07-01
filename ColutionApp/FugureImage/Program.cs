// See https://aka.ms/new-console-template for more information

using FugureImage;

internal class Program
{
    public static void Main(string[] args)
    {
        Circle circle1 = new Circle(4);
        circle1.Draw();
        Rectangle rec = new Rectangle(5, 3);
        rec.Draw();
        Console.WriteLine();
        Console.WriteLine();
        Square square = new Square(5);
        square.Draw();
        Triangle triangle = new Triangle(5, 5, 5);
        triangle.Draw();
    }
}