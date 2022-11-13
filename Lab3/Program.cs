namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create triangle and rectangle
            Triangle t = new Triangle(3, 4);
            Rectangle r = new Rectangle(3, 4);
            // getArea and toString both
            Console.WriteLine(t.ToString());
            Console.WriteLine("Area: {0}", t.GetArea());
            Console.WriteLine(r.ToString());
            Console.WriteLine("Area: {0}", r.GetArea());
            // Create MovablePoint object
            MovablePoint mp = new MovablePoint(1, 2);
            Console.WriteLine(mp.ToString());
            // move the point
            mp.MoveUp();
            mp.MoveRight();
            Console.WriteLine(mp.ToString());

            Fish d = new Fish();

            Cat c = new Cat("Fluffy");

            Animal a = new Fish();

            Animal e = new Spider();

            Pet p = new Cat();

            // toString() for all animal
            Console.WriteLine(d.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(a.ToString());
            Console.WriteLine(e.ToString());
            Console.WriteLine(p.ToString());
        }
    }
}