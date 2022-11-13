// Student with private int numCourses and string[] courses and int[] grades
using System;
using System.Collections;

namespace Lab2 {
    public class Student : Person
    {
        private int numCourses;
        // arraylist of courses
        private List<String> courses;
        // arraylist of grades
        private List<int> grades;

        public Student(string name, string address) : base(name, address)
        {
            numCourses = 0;
            courses = new List<String>();
            grades = new List<int>();
        }

        public void addCourseGrade(string course, int grade)
        {
            courses.Add(course);
            grades.Add(grade);
            numCourses++;
        }

        public void printGrades()
        {
            Console.WriteLine("Grades for {0}", Name);
            for (int i = 0; i < numCourses; i++)
            {
                Console.WriteLine("{0}: {1}", courses[i], grades[i]);
            }
        }

        public double getAverageGrade()
        {
            int sum = 0;
            for (int i = 0; i < numCourses; i++)
            {
                sum += grades[i];
            }
            return (double)sum / numCourses;
        }

        public override string ToString()
        {
            return string.Format("Student: {0}", base.ToString());
        }
    }
}