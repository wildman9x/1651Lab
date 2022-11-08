public class Point3D : Point2D
{
    public int Z { get; set; }
    public Point3D() : base()
    {
        Z = 0;
    }
    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }
    public override string ToString()
    {
        return string.Format("({0}, {1}, {2})", X, Y, Z);
    }
}