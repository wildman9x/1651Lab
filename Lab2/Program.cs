namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Point2D object
            Point2D p2d = new Point2D();
            Console.WriteLine(p2d.ToString());
            // another way to create a Point2D object
            Point2D p2d2 = new Point2D(1, 2);
            Console.WriteLine(p2d2.ToString());
            // Create a Point3D object
            Point3D p3d = new Point3D();
            Console.WriteLine(p3d.ToString());
            // another way to create a Point3D object
            Point3D p3d2 = new Point3D(1, 2, 3);
            Console.WriteLine(p3d2.ToString());

            // Create a Student object
            Student s = new Student("John", "123 Main St");
            s.addCourseGrade("CSC 101", 100);
            s.addCourseGrade("CSC 102", 90);
            s.addCourseGrade("CSC 103", 80);
            s.printGrades();
            Console.WriteLine("Average grade: {0}", s.getAverageGrade());
            Console.WriteLine(s.ToString());
            // Create a Teacher object
            Teacher t = new Teacher("Jane", "456 Main St");
            t.addCourse("CSC 101");
            t.addCourse("CSC 102");
            t.addCourse("CSC 103");
            t.removeCourse("CSC 103");
            Console.WriteLine(t.ToString());

            // Create a Square, Circle, and Rectangle object with color and filled
            Square sq = new Square(5, "red", true);
            Console.WriteLine(sq.ToString());
            // get the area and perimeter of the square
            Console.WriteLine("Area: {0}", sq.getArea());
            Console.WriteLine("Perimeter: {0}", sq.getPerimeter());
            Circle2 c = new Circle2(5, "blue", false);
            Console.WriteLine(c.ToString());
            // getArea and getPerimeter
            Console.WriteLine("Area: {0}", c.getArea());
            Console.WriteLine("Perimeter: {0}", c.getPerimeter());
            Rectangle r = new Rectangle(5, 10, "green", true);
            // getArea and getPerimeter
            Console.WriteLine("Area: {0}", r.getArea());
            Console.WriteLine("Perimeter: {0}", r.getPerimeter());
            Console.WriteLine(r.ToString());
            

        }
    }
}