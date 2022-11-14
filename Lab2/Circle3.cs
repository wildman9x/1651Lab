// Circle3 class with double radius
namespace Lab2
{
    public class Circle3
    {
        public readonly double radius = 0;

        public double Radius
        {
            get { return radius; }
        }

        public Circle3()
        {
            radius = 1.0;
        }

        public Circle3(double radius)
        {
            radius = radius;
        }


        public virtual double getArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return string.Format("Circle[radius={0}]", Radius);
        }
    }
}