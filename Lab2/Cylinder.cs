// class Cylinder extends Circle

public class Cylinder : Circle3 {
    public double Height { get; private set; }

    public Cylinder() {
        Height = 1.0;
    }

    public Cylinder(double height) {
        Height = height;
    }

    public Cylinder(double height, double radius) : base(radius) {
        Height = height;
    }

    public Cylinder(double height, double radius, String color) : base(radius, color) {
        Height = height;
    }

    public double getArea() {
        return 2 * Math.PI * Radius * Radius + 2 * Math.PI * Radius * Height;
    }

    public double getVolume() {
        return getArea() * Height;
    }

    public override string ToString() {
        return string.Format("Cylinder[height={0},radius={1}]", Height, Radius);
    }
}