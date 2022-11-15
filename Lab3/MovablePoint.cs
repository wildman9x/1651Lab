// class MovablePoint that implements the IMovable interface.
// has private int x, y
// constructor that takes in x and y

// default constructor that sets x and y to 0
namespace Lab3 {
    class MovablePoint : IMovable {
        private int x = 0;
        private int y = 0;

        public MovablePoint(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public MovablePoint() {
            x = 0;
            y = 0;
        }

        public void MoveUp() {
            y++;
        }
        public void MoveDown() {
            y--;
        }
        public void MoveLeft() {
            x--;
        }
        public void MoveRight() {
            x++;
        }
        public override string ToString() {
            return "MovablePoint with x = " + x + " and y = " + y;
        }
    }
}