// See https://aka.ms/new-console-template for more information
public class Rectangle
{
    public int X;
    public int Y;
    public int H;
    public int W;
    public Rectangle(int x, int y, int h, int w)
    {
        X = x;
        Y = y;
        H = h;
        W = w;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(10, 20, 30, 40);
        Rectangle rect2 = new Rectangle(50, 60, 70, 80);
        Console.WriteLine(IsColliding(rect1, rect2));
    }
    public static bool IsColliding(Rectangle rect1, Rectangle rect2)
    {
        if (rect1.X + rect1.W < rect2.X || rect2.X + rect2.W < rect1.X ||
           rect1.Y + rect1.H < rect2.Y || rect2.Y + rect2.H < rect1.Y)
        {
            return false;
        }

        return true;
    }

}