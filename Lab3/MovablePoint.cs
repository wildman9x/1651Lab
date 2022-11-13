// class MovablePoint that implements the IMovable interface.
// has private int x, y
// constructor that takes in x and y

// default constructor that sets x and y to 0
namespace Lab3 {
    class MovablePoint : IMovable {
        private int X { get; set; }
        private int Y { get; set; }

        public MovablePoint(int x, int y) {
            X = x;
            Y = y;
        }
        public MovablePoint() {
            X = 0;
            Y = 0;
        }

        public void MoveUp() {
            Y++;
        }
        public void MoveDown() {
            Y--;
        }
        public void MoveLeft() {
            X--;
        }
        public void MoveRight() {
            X++;
        }
        public override string ToString() {
            return "MovablePoint with x = " + X + " and y = " + Y;
        }
    }
}