using System.Text;

Point point = new Point();
Console.WriteLine($"point.X = {point.X}, point.Y = {point.Y}");

Point point1 = new Point(2, 6);
Console.WriteLine($"point1.X = {point1.X}, point1.Y = {point1.Y}");
// В структурах копирование всегда глубокое копирование 
Point point2 = new(36, 12);
Point point3 = point1;

//StringBuilder stringBuilder = new();
//var stringBuilder2 = new StringBuilder();
public struct Point
{
    public int X;
    public int Y;
    // Нельзя перегружать конструктор по умолчанию
    //public Point()
    //{
        
    //}
    public Point(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }
}

