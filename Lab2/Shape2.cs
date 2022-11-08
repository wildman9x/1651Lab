// class shape with private string color and getArea() method and toString() method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Shape2
{
    public String Color { get; private set; }

    public Shape2()
    {
        Color = "red";
    }

    public Shape2(String color)
    {
        Color = color;
    }

    public double getArea() {
        return 0.0;
    }

    public override string ToString()
    {
        return "Shape[color=" + Color + "]";
    }
}