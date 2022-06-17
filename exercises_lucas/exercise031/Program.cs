public class Program
{
    public static void Main ()
    {
        Point p1 = new(1,1);
        Point p2 = new(7,3);
        Point p3 = new(7, 3);
        Console.WriteLine(GetCircumference(p1, p2, p3));
        p3 = new(4,3);
        Console.WriteLine(GetCircumference(p1, p2, p3));

    }

    public static double GetCircumference(Point pointA, Point pointB, Point pointC)
    {
        double SideA = pointB.GetDistance(pointC);
        double SideB = pointA.GetDistance(pointC);
        double SideC = pointA.GetDistance(pointB);

        return SideA + SideB + SideC;
    }
}

public class Point
{
    public int Y { get; set; }
    public int X { get; set; }

    public Point(int y, int x)
    {
        X = x;
        Y = y;
    }

    public void PrintCoordinates()
    {
        Console.WriteLine($"{X}//{Y}");
    }

    public double GetDistance(Point point)
    {
        int sideA = Y - point.Y;
        int sideC = X - point.X;
        return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideC, 2));
    }
}