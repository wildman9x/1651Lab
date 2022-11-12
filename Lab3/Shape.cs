// Abstract class Shape  with private string color
//  and abstract double getArea()
// toString() method

namespace Lab3 {
    abstract class Shape {
        public string Color { get; set; }
        // constructor
        public Shape(string color) {
            Color = color;
        }
        // default constructor
        public Shape() {
            Color = "red";
        }
        public abstract double GetArea();
        public virtual string ToString() {
            return "Shape with color of " + Color;
        }
    }
}