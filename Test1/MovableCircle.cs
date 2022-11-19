using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1
{
    public class MovableCircle : Movable
    {
        private int radius;
        private MovablePoint center;

        public MovableCircle(int x, int y, int xSpeed, int ySpeed, int radius) 
        {
            this.radius = radius;
            center = new MovablePoint(x, y, xSpeed, ySpeed);
        }

        public void moveUp()
        {
            center.moveUp();
        }

        public void moveDown()
        {
            center.moveDown();
        }

        public void moveLeft()
        {
            center.moveLeft();
        }

        public void moveRight()
        {
            center.moveRight();
        }

        public override string ToString()
        {
            return "radius: " + radius + " " + center.ToString();
        }
    }
}