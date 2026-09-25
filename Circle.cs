public class Circle : Figure
{
    private double radius;

    public double Radius
    {
        get { 
            return radius; 
            }
        set { 
            radius = value; 
            }
    }

    public Circle(int x, int y, double radius) : base(x, y)
    {
        this.radius = radius;
    }
}