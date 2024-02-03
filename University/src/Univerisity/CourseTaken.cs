using System.Drawing;

namespace Univerisity;

public class CourseTaken : Course
{
    public DateTime EnrolmentDate { get; set; }
    public DateTime? EndEnrolment { get; set; }
    public string CompletionStatus { get; set; }
    
     public CourseTaken(String courseName,string major ,DateTime enrolmentDate, DateTime? endEnrolment, string completionStatus, int point):base(courseName, major,point)
    {
        EnrolmentDate = enrolmentDate;
        EndEnrolment = endEnrolment;
        CompletionStatus = completionStatus;
    }
}
