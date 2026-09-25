public class Square : Figure
{
    private double side;

    public double Side
    {
        get { return side; }
        set { side = value; }
    }

    public Square(int x, int y, double side) : base(x, y)
    {
        this.side = side;
    }
}