namespace TestConsoleApp{
public class Circle
{
    public double Radius { get; set; }
    public Circle(){
        Radius = 1;
    }

    public Circle(double radius){
        Radius = radius;
    }

    public double Area(){
        return Math.PI * Radius * Radius;
    }

    public double Circumference(){
        return 2 * Math.PI * Radius;
    }

    public override string ToString(){
        return "Circle with radius " + Radius;
    }
}
}