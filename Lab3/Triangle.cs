// Triangle class with private int base and height
// double override getArea()
// toString() method

namespace Lab3 {
    class Triangle : Shape {
        private int Base { get; set; }
        private int Height { get; set; }

        public Triangle(): base() {
            Base = 1;
            Height = 1;
        }
        public Triangle(int @base, int height) {
            Base = @base;
            Height = height;
        }

        // constructor that also takes in a color
        public Triangle(int @base, int height, string color) : base(color) {
            Base = @base;
            Height = height;
        }


        public override double GetArea() {
            return 0.5 * Base * Height;
        }
        public override string ToString() {
            return "Triangle with base " + Base + " and height " + Height;
        }
    }
}