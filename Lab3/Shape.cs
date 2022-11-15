// Abstract class Shape  with private string color
//  and abstract double getArea()
// toString() method

namespace Lab3 {
    abstract class Shape {
        private string color;
        // constructor
        public Shape(string color) {
            this.color = color;
        }
        // default constructor
        public Shape() {
            color = "red";
        }
        public abstract double GetArea();
        public virtual string ToString() {
            return "Shape with color of " + color;
        }
    }
}