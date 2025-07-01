namespace FugureImage;

public class Rectangle: IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        
        Width = width;
        Height = height;
    }
    
    public void Draw()
    {
        for (int i = 0; i < Width; i++)
        {

            for (int j = 0; j < Height; j++)
            {
                Console.Write('*' + new string(' ',2));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}