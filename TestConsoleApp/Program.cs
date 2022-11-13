// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // create a new circle
            Circle c = new Circle();
            // print the circle
            Console.WriteLine(c);
            // print the area and circumference
            Console.WriteLine("Area: " + c.Area());
            Console.WriteLine("Circumference: " + c.Circumference());

            // create a new circle with radius 3.0
            Circle c2 = new Circle(3.0);
            // print the circle
            Console.WriteLine(c2);
            // print the area and circumference
            Console.WriteLine("Area: " + c2.Area());
            Console.WriteLine("Circumference: " + c2.Circumference());
            // create employee
            Employee e = new Employee(123, "John", "Smith", 1000);
            // print the employee
            Console.WriteLine(e);
            // Construct an author instance

            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');

            Console.WriteLine(ahTeck); // Author's ToString()

            Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99); // Test Book's Constructor

            Console.WriteLine(dummyBook); // Test Book's ToString()

            // Test Getters and Setters

            dummyBook.Price = 29.95;

            dummyBook.QtyInStock = 28;

            Console.WriteLine("name is: " + dummyBook.Name);

            Console.WriteLine("price is: " + dummyBook.Price);

            Console.WriteLine("qty is: " + dummyBook.QtyInStock);

            Console.WriteLine("Author is: " + dummyBook.Author); // Author's ToString()

            Console.WriteLine("Author's name is: " + dummyBook.Author.Name);

            Console.WriteLine("Author's email is: " + dummyBook.Author.Email);

            // Use an anonymous instance of Author to construct a Book instance

            Book anotherBook = new Book("more Java",

            new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);

            Console.WriteLine(anotherBook); // ToString()
                                            // Declare and allocate an array of Authors

            Author[] authors = new Author[2];

            authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');

            authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');

            // Declare and allocate a Book instance

            Book2 javaDummy = new Book2("Java for Dummy", authors, 19.99, 99);

            Console.WriteLine(javaDummy); // ToString()
            // write all authors name
            Console.WriteLine(javaDummy.GetAuthorNames());

            // readkey to end program
            Console.ReadKey();
        }
    }
}
