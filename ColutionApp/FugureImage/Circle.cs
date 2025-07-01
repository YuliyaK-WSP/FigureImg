namespace FugureImage;

public class Circle: IShape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }
    public void Draw()
    {
        // Уравнение круга: (x - r)^2 + (y - r)^2 = r^2
        int deametr = Radius * 2;

        for (int i = 0; i <= deametr; i++)
        {
            for (int j = 0; j <= deametr; j++)
            {
                // Уравнение круга: (x - r)^2 + (y - r)^2 = r^2
                if (Math.Pow(i - Radius, 2) + Math.Pow(j - Radius, 2) <= Math.Pow(Radius, 2))
                {
                    Console.Write('*' + new string(' ', 2));
                }
                else
                {
                    Console.Write(new string(' ',3));
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}