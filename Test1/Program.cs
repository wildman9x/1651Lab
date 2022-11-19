using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user to input a temperature, print its value in Fahrenheit, Celsius, and Kelvin
            // after that, ask the user if they want to repeat the process
            // if they do, repeat the process
            Temperature t = new Temperature();
            bool repeat = true;
            while (repeat)
            {
                Console.Write("Enter a temperature in Fahrenheit: ");
                double f = Convert.ToDouble(Console.ReadLine());
                t.setFahrenheit(f);
                Console.WriteLine(t.ToString());
                Console.Write("Do you want to repeat the process? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == "n" || answer == "N")
                {
                    repeat = false;
                }
            }
            Movable m1 = new MovablePoint(5, 6, 10, 15); // upcast

            Console.WriteLine(m1);

            m1.moveLeft();

            Console.WriteLine(m1);

            Movable m2 = new MovableCircle(1, 2, 3, 4, 20); // upcast

            Console.WriteLine(m2);

            m2.moveRight();

            Console.WriteLine(m2);

            // Create a MovableRectangle object and test the moveUp(), moveDown(), moveLeft(), moveRight() methods
            Movable m3 = new MovableRectangle(1, 2, 3, 4, 5, 6); // upcast

            Console.WriteLine(m3);

            m3.moveRight();

            Console.WriteLine(m3);

            
        }
    }
}