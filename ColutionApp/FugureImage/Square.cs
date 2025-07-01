using System.Security.Principal;

namespace FugureImage;

public class Square: Rectangle
{
    // используется конструктор класса прямоугольник,
    // так как квадрат это тот же прямоугольник,но с равными сторонами
    public Square(int side ):base(side,side)
    {
        
    }
    
}