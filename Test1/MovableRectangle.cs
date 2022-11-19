using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1
{
    public class MovableRectangle : Movable
    {
        private MovablePoint topLeft;
        private MovablePoint bottomRight;

        public MovableRectangle(int x1, int y1, int x2, int y2, int xSpeed, int ySpeed)
        {
            topLeft = new MovablePoint(x1, y1, xSpeed, ySpeed);
            bottomRight = new MovablePoint(x2, y2, xSpeed, ySpeed);
        }

        public void moveUp()
        {
            topLeft.moveUp();
            bottomRight.moveUp();
        }

        public void moveDown()
        {
            topLeft.moveDown();
            bottomRight.moveDown();
        }

        public void moveLeft()
        {
            topLeft.moveLeft();
            bottomRight.moveLeft();
        }

        public void moveRight()
        {
            topLeft.moveRight();
            bottomRight.moveRight();
        }

        public override string ToString()
        {
            return "topLeft: " + topLeft.ToString() + " bottomRight: " + bottomRight.ToString();
        }
        
    }
}