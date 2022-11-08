// teacher class with int numCourses and List<String> courses
using System;
using System.Collections;

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
            return false;
        }
        else
        {
            courses.Add(course);
            numCourses++;
            return true;
        }
    }

    public bool removeCourse(string course)
    {
        if (courses.Contains(course))
        {
            courses.Remove(course);
            numCourses--;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return string.Format("Teacher: {0}", base.ToString());
    }
}