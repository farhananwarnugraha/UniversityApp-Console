using Univerisity.Enumuration;
using static Univerisity.InstantietData;
using static Univerisity.Menu;

namespace Univerisity;

public class Lecturer : Person
{
    public string LecturerNumber { get; set; }
    public decimal Sallary { get; set; }
    public DateTime HireDate { get; set; }
    public List<Course> LecturerCourse { get; set; }

    public Lecturer(string noKTP,string lecturerNumber,string firstName, string lastName, Gender gender, DateTime bhirthDate, string bhirthPlace,int age,TypeBlood bloodType,Religion religion, decimal sallary, DateTime hireDate, List<Course> lecturerCourse)
    :base(noKTP, firstName,lastName,gender,bhirthDate,bhirthPlace,age,bloodType,religion)
    {
        LecturerNumber = lecturerNumber;
        Sallary = sallary;
        HireDate = hireDate;
        LecturerCourse = lecturerCourse;
    }

     public static void DisplayAllLecturer(){
        foreach (KeyValuePair<int, Lecturer> lecturerList in LecturerList())
        {
            System.Console.WriteLine($"NIK: {lecturerList.Value.LecturerNumber}, Name: {lecturerList.Value.FirstName} {lecturerList.Value.LastName}");
        }
    }

    public static void SearchDetailLecturer(){
        System.Console.WriteLine("Masukan nomor NIK yang anda ingin lihat informasinya: ");
        string chooseLecturerNumber = Console.ReadLine();
        List<Lecturer> lecturers = DetailLecturer(chooseLecturerNumber);
        DisplayDetailDataLecturer(lecturers);
    }

    public static List<Lecturer> DetailLecturer(string input){
        Dictionary<int, Lecturer> detailLecturer = InstantietData.LecturerList();
        List<Lecturer> resultDataLecturer = (
            from entry in detailLecturer where entry.Value.LecturerNumber.Contains(input, StringComparison.OrdinalIgnoreCase)
            select entry.Value
        ).ToList();
        return resultDataLecturer;
    }

    public static void DisplayDetailDataLecturer(List<Lecturer> input){
        if(input.Count > 0){
            foreach (Lecturer lecturer in input)
            {
                List<Lecturer> temp = input;
                DateTime workDate = temp[0].HireDate;
                DateTime now = DateTime.Now;
                TimeSpan longerWorkinghDate = now - workDate;
                DateTime differentHireDate = DateTime.MinValue + longerWorkinghDate;
                int workInYears = differentHireDate.Year -1;
                int workInMounth = differentHireDate.Month -1;
                int workInDay = differentHireDate.Day -1;

                DateTime birthDate = temp[0].BhirthDate;
                TimeSpan lifeDifference = now - birthDate;
                DateTime differenAge = DateTime.MinValue + lifeDifference;
                int age = differenAge.Year -1;
                lecturer.Age = age;
                System.Console.WriteLine($"First Name: {lecturer.FirstName}");
                System.Console.WriteLine($"Last Name: {lecturer.LastName}");
                System.Console.WriteLine($"Gender: {lecturer.Gender}");
                System.Console.WriteLine($"Birth Information: {lecturer.BhirthPlace}, {lecturer.BhirthDate : dd MMMM yyyy}, ({lecturer.Age} tahun)");
                System.Console.WriteLine($"Relogion: {lecturer.Religion}");
                System.Console.WriteLine($"Blood Type: {lecturer.BloodType}");
                System.Console.WriteLine($"ID Card: {lecturer.NoKTP}");
                System.Console.WriteLine($"Entry Date: {lecturer.HireDate : dd MMMM yyyy}, ({workInYears} tahun, {workInMounth} bulan, {workInDay} hari)");
                System.Console.WriteLine("");
                System.Console.WriteLine("Competency Infomation: ");
                for(int index=0; index<lecturer.LecturerCourse.Count; index++){
                    System.Console.WriteLine($"{lecturer.LecturerCourse[index].CourseName}");
                }
            }
            SeccondSubmenuLecturer();
        }
        else{
            System.Console.WriteLine("Data tidak ditemukan");
            SearchDetailLecturer();
        }    
    }
}
