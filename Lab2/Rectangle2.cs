// class Rectangle2 extends class Shape2
// int length and width
namespace Lab2 {
    public class Rectangle2 : Shape2
    {
        private int length = 0;
        private int width = 0;

        public Rectangle2()
        {
            length = 1;
            width = 1;
        }

        public Rectangle2(int Length, int Width)
        {
            this.length = Length;
            this.width = Width;
        }

        public Rectangle2(int Length, int Width, String color) : base(color)
        {
            this.length = Length;
            this.width = Width;
        }

        public new double getArea()
        {
            return length * width;
        }

        public override string ToString()
        {
            return string.Format("Rectangle[length={0},width={1},color={2}]", length, width, Color);
        }
    }
}