// teacher class with int numCourses and List<String> courses
using System;
using System.Collections;
namespace Lab2 {
    public class Teacher : Person
    {
        private int numCourses;
        private List<String> courses;

        public Teacher(string name, string address) : base(name, address)
        {
            numCourses = 0;
            courses = new List<String>();
        }

        public bool addCourse(string course)
        {
            if (courses.Contains(course))
            {
                Console.WriteLine("Course already exists");
                return false;
            }
            else
            {
                courses.Add(course);
                numCourses++;
                Console.WriteLine("Course " + course + " has been added");
                return true;
            }
        }

        public bool removeCourse(string course)
        {
            if (courses.Contains(course))
            {
                courses.Remove(course);
                numCourses--;
                Console.WriteLine("Course " + course + " has been removed");
                return true;
            }
            else
            {
                Console.WriteLine("Course does not exist");
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("Teacher: {0}", base.ToString());
        }
    }
}