using Univerisity.Enumuration;
using static Univerisity.InstantietData;
using static Univerisity.Menu;

namespace Univerisity;

public class Student : Person
{
    public string StudentNumber { get; set; }
    public DateTime RegisterDate { get; set; }
    public List<CourseTaken> StudentCourses { get; set; }

    public Student(string noKTP,string studentNumber,string firstName,string lastName, Gender gender, DateTime bhirthDate, string bhirthPlace, int age, TypeBlood bloodType,Religion religion ,DateTime registerDate, List<CourseTaken> studentCourses)
    :base(noKTP, firstName,lastName,gender,bhirthDate,bhirthPlace,age,bloodType,religion)
    {
        StudentNumber = studentNumber;
        RegisterDate = registerDate;
        StudentCourses = studentCourses;
    }

    public static void DisplayAllStudent(){
        foreach (KeyValuePair<string, Student> studentList in StudentList())
        {
            System.Console.WriteLine($"NIK: {studentList.Key}, Name: {studentList.Value.FirstName} {studentList.Value.LastName}");
        }
    }

    public static void SearchDetailStudent(){
        System.Console.WriteLine("Masukan nomor NIK yang anda ingin lihat informasinya: ");
        string chooseStudentNumber = Console.ReadLine();
        List<Student> result =  DetailStudent(chooseStudentNumber);
        DisplayDetailStudent(result);
    }

    public static List<Student> DetailStudent(string input){
        Dictionary<string, Student> detailStudent = InstantietData.StudentList();
        List<Student> resultSearch = (
            from entry in detailStudent
            where entry.Value.StudentNumber.Contains(input, StringComparison.OrdinalIgnoreCase)
            select entry.Value
        ).ToList();
        return resultSearch;
    }

    public static void DisplayDetailStudent(List<Student> input){
        if(input.Count > 0){
            foreach (Student detailStudentData in input)
            {
                List<Student> temporary = input;
                DateTime dateOfEntry = temporary[0].RegisterDate;
                DateTime now = DateTime.Now;
                TimeSpan differentInEntry = now - dateOfEntry; 
                DateTime differentEntry = DateTime.MinValue + differentInEntry;
                int year = differentEntry.Year-1;
                int mounth = differentEntry.Month-1;
                int day = differentEntry.Day -1;

                DateTime dateAge = temporary[0].BhirthDate;
                TimeSpan ageResult = now - dateAge;
                DateTime age = DateTime.MinValue + ageResult;
                int finalAge = age.Year - 1;
                detailStudentData.Age = finalAge;
                System.Console.WriteLine($"First Name: {detailStudentData.FirstName}");
                System.Console.WriteLine($"Last Name: {detailStudentData.LastName}");
                System.Console.WriteLine($"Gender: {detailStudentData.Gender}");
                System.Console.WriteLine($"Birth Information:: {detailStudentData.BhirthPlace} {detailStudentData.BhirthDate : dd MMMM yyyy} ({detailStudentData.Age} tahun)");
                System.Console.WriteLine($"Religion: {detailStudentData.Religion}");
                System.Console.WriteLine($"Blood Type: {detailStudentData.BloodType}");
                System.Console.WriteLine($"ID Card: {detailStudentData.NoKTP}");
                System.Console.WriteLine($"Entery Date(Duration): {detailStudentData.RegisterDate : dd MMMM yyyy} ({year} tahun, {mounth} bulan, {day} hari)");
                System.Console.WriteLine("-----------------------------------------------------");
                System.Console.WriteLine($"Enrolment Information :");
                for(int idx = 0; idx < detailStudentData.StudentCourses.Count; idx++){
                    System.Console.WriteLine($"{detailStudentData.StudentCourses[idx].CourseName} in {detailStudentData.StudentCourses[idx].Major},({detailStudentData.StudentCourses[idx].EnrolmentDate: dd/MM/yyyy}-{detailStudentData.StudentCourses[idx].EndEnrolment: dd/MM/yyyy}), + {detailStudentData.StudentCourses[idx].Point}");
                }
            }
            SeccondSubmenuStudent();
        }
        else{
            System.Console.WriteLine("Data Tidak ditemukan, silahkan inputkan kembali");
            SearchDetailStudent();
        }
        
    }
}
