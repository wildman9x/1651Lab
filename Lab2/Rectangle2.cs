// class Rectangle2 extends class Shape2
// int length and width
namespace Lab2 {
    public class Rectangle2 : Shape2
    {
        private int Length { get; set; }
        private int Width { get; set; }

        public Rectangle2()
        {
            Length = 1;
            Width = 1;
        }

        public Rectangle2(int Length, int Width)
        {
            this.Length = Length;
            this.Width = Width;
        }

        public Rectangle2(int Length, int Width, String color) : base(color)
        {
            this.Length = Length;
            this.Width = Width;
        }

        public new double getArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return string.Format("Rectangle[length={0},width={1},color={2}]", Length, Width, Color);
        }
    }
}