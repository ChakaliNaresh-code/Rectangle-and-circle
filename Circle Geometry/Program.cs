public class Circle
{
    public int X;
    public int Y;
    public int CX;
    public int CY;
    public int R;
    public Circle(int x, int y,int cx,int cy, int r)
    {
        X = x;
        Y = y;
        CX = cx;
        CY = cy;
        R = r;
    }
}
public class CircleGeometryExample
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(10, 20,0,0, 5);
        //Circle circle2 = new Circle(25, 30, 10);
        Console.WriteLine(IsPointInside(circle1));
    }
    public static bool IsPointInside(Circle circle1)
    {
        int dx = circle1.X - circle1.CX;
        int dy = circle1.Y - circle1.CY;
        int distanceSquared = dx * dx + dy * dy;
        int radiusSum = circle1.R;
        return distanceSquared <= radiusSum * radiusSum;
    }
}
