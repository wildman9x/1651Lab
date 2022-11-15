// Triangle class with private int base and height
// double override getArea()
// toString() method

namespace Lab3 {
    class Triangle : Shape {
        private int @base = 0;
        private int height = 0;

        public Triangle(): base() {
            @base = 1;
            height = 1;
        }
        public Triangle(int @base, int height) {
            this.@base = @base;
            this.height = height;
        }

        // constructor that also takes in a color
        public Triangle(int @base, int height, string color) : base(color) {
            this.@base = @base;
            this.height = height;
        }


        public override double GetArea() {
            return 0.5 * @base * height;
        }
        public override string ToString() {
            return "Triangle with base " + @base + " and height " + height;
        }
    }
}