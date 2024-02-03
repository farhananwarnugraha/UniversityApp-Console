using System.Net.NetworkInformation;

namespace Univerisity;

public class Course
{
    public string CourseName { get; set; }
    public string Major { get; set; }
    public int Point { get; set; }


    public Course(string courseName)
    {
        CourseName = courseName;
    }

    public Course(string courseName, string major, int point)
    {
        CourseName = courseName;
        Major = major;
        Point = point;
    }
}
