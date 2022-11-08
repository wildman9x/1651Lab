// Triangle class extends to shape2
// int base and height
// override getArea() method

public class Triangle : Shape2
{
    private int Base { get; set; }
    private int Height { get; set; }

    public Triangle()
    {
        Base = 1;
        Height = 1;
    }

    public Triangle(int Base, int Height)
    {
        this.Base = Base;
        this.Height = Height;
    }

    public Triangle(int Base, int Height, String color) : base(color)
    {
        this.Base = Base;
        this.Height = Height;
    }

    public double getArea()
    {
        return 0.5 * Base * Height;
    }

    public override string ToString()
    {
        return string.Format("Triangle[base={0},height={1},color={2}]", Base, Height, Color);
    }
}