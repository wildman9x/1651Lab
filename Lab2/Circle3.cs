// Circle3 class with double radius

public class Circle3 {
    public double Radius { get; private set; }

    public Circle3() {
        Radius = 1.0;
    }

    public Circle3(double radius) {
        Radius = radius;
    }


    public double getArea() {
        return Math.PI * Radius * Radius;
    }

    public override string ToString() {
        return string.Format("Circle[radius={0}]", Radius);
    }
}