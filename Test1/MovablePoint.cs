using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1
{
    public class MovablePoint : Movable
    {
        internal int x;
        internal int y;
        internal int xSpeed;
        internal int ySpeed;

        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public void moveUp()
        {
            y += ySpeed;
        }

        public void moveDown()
        {
            y -= ySpeed;
        }

        public void moveLeft()
        {
            x -= xSpeed;
        }

        public void moveRight()
        {
            x += xSpeed;
        }

        public override string ToString()
        {
            return "x: " + x + " y: " + y + " xSpeed: " + xSpeed + " ySpeed: " + ySpeed;
        }
    }
}