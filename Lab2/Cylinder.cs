// class Cylinder extends Circle
namespace Lab2
{
    public class Cylinder : Circle3
    {
        public readonly double height = 0;

        public double Height
        {
            get { return height; }
        }

        public Cylinder()
        {
            height = 1.0;
        }

        public Cylinder(double height)
        {
            this.height = height;
        }

        public Cylinder(double height, double radius) : base(radius)
        {
            this.height = height;
        }

        public Cylinder(double height, double radius, String color) : base(radius)
        {
            this.height = height;
        }

        public override double getArea()
        {
            return 2 * Math.PI * Radius * Radius + 2 * Math.PI * Radius * Height;
        }

        public double getVolume()
        {
            return getArea() * Height;
        }

        public override string ToString()
        {
            return string.Format("Cylinder[height={0},radius={1}]", Height, Radius);
        }
    }
}