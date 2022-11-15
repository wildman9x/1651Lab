// Circle3 class with double radius
namespace Lab2
{
    public class Circle3
    {
        private readonly double radius;

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
            this.radius = radius;
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