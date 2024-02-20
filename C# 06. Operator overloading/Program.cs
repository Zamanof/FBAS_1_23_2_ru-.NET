// operator overloading
Point point = new(x: 3, y: 3);
Point point2 = new Point
{
    X = 3,
    Y = 0
};
//Console.WriteLine(point);
//Console.WriteLine(point2);
//point++;
//Console.WriteLine(-point);
//Console.WriteLine(point + point2);
//Console.WriteLine(point * 2);
//Console.WriteLine(3 * point);

//Console.WriteLine(point.Equals(point2));
//Console.WriteLine(point == point2);
//Console.WriteLine(point != point2);
Console.WriteLine(point | point2);
Console.WriteLine(point || point2);
//if (point)
//{
//    Console.WriteLine("Point not in coordinates start");
//}
//else
//{
//    Console.WriteLine("Point in coordinates start");
//}


class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point()
    {
        X = default;
        Y = default;
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"Point (X:{X}, Y:{Y})";
    }

    // Unary operators overloading
    public static Point operator ++(Point p)
    {
        p.X++;
        p.Y++;
        return p;
    }

    public static Point operator --(Point p)
    {
        p.X--;
        p.Y--;
        return p;
    }

    public static Point operator -(Point p)
    {
        return new(-p.X, -p.Y);
    }

    // Binary operators overloading

    public static Point operator +(Point p1, Point p2)
    {
        return new Point
        {
            X = p1.X + p2.X,
            Y = p1.Y + p2.Y
        };
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point
        {
            X = p1.X - p2.X,
            Y = p1.Y - p2.Y
        };
    }

    public static Point operator *(Point p1, int value)
    {
        return new Point
        {
            X = p1.X * value,
            Y = p1.Y * value
        };
    }
    public static Point operator *(int value, Point p1)
    {
        return new Point
        {
            X = p1.X * value,
            Y = p1.Y * value
        };
    }

    // 
    public override bool Equals(object? obj)
    {
        return this.ToString() == obj?.ToString();
    }

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    public static bool operator ==(Point p1, Point p2)
    {
        return p1.Equals(p2);
    }

    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }
    public static bool operator >(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2)) >
                Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));
    }
    public static bool operator <(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2)) <
                Math.Sqrt(Math.Pow(p2.X, 2) + Math.Pow(p2.Y, 2));
    }

    public static bool operator true(Point point)
    {
        return point.X != 0 || point.Y != 0 ? true : false;
    }
    public static bool operator false(Point point)
    {
        return point.X == 0 || point.Y == 0 ? true : false;
    }

    public static Point operator |(Point p1, Point p2)
    {
        if ((p1.X != 0 || p1.Y != 0) || (p2.X != 0 || p2.Y != 0))
        {
            return p2;
        }
        return new Point();
    }
    public static Point operator &(Point p1, Point p2)
    {
        if ((p1.X != 0 && p1.Y != 0) && (p2.X != 0 && p2.Y != 0))
        {
            return p2;
        }
        return new Point();
    }
}
