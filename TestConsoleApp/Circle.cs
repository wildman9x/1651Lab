namespace TestConsoleApp{
public class Circle
{
    private double Radius { get; set; }
    public double pi = Math.PI;
    public Circle(){
        Radius = 1;
    }

    public Circle(double radius){
        Radius = radius;
    }

    public double Area(){
        return pi * Radius * Radius;
    }

    public double Circumference(){
        return 2 * pi * Radius;
    }

    public override string ToString(){
        return "Circle with radius " + Radius;
    }
}
}