namespace Lab2
{
    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point2D()
        {
            X = 0;
            Y = 0;
        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}