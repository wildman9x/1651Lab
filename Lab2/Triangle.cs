// Triangle class extends to shape2
// int base and height
// override getArea() method
namespace Lab2 {
    public class Triangle : Shape2
    {
        private int @base = 1;
        private int height = 1;


        public Triangle()
        {
            @base = 1;
            height = 1;
        }

        public Triangle(int Base, int Height)
        {
            this.@base = Base;
            this.height = Height;
        }

        public Triangle(int Base, int Height, String color) : base(color)
        {
            this.@base = Base;
            this.height = Height;
        }

        public new double getArea()
        {
            return 0.5 * @base * height;
        }

        public override string ToString()
        {
            return string.Format("Triangle[base={0},height={1},color={2}]", @base, height, Color);
        }
    }
}