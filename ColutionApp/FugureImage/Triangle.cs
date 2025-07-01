namespace FugureImage;

public class Triangle: IShape
{
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }

    public Triangle(int sideA, int sideB, int sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    public void Draw()
    {
        int height = SideA;
        int width = height * 2;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (j < height - i || j > height + i)
                {
                    Console.Write(new string(' ',3));
                }
                else
                {
                    Console.Write('*' + new string(' ',2));
                }
            }
            Console.WriteLine();
        }
    }
}