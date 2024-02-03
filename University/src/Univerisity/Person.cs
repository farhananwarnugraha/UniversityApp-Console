using Univerisity.Enumuration;

namespace Univerisity;

public class Person
{
    public string NoKTP { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DateTime BhirthDate { get; set; }
    public string BhirthPlace { get; set; }
    public int Age { get; set; }
    public TypeBlood BloodType { get; set; }
    public Religion Religion { get; set; }

    public Person(string noKTP, string firstName, string lastName, Gender gender, DateTime bhirthDate, string bhirthPlace, int age, TypeBlood bloodType, Religion religion)
    {
        NoKTP = noKTP;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        BhirthDate = bhirthDate;
        BhirthPlace = bhirthPlace;
        Age = age;
        BloodType = bloodType;
        Religion = religion;
    }

    public int CountAge(){
        int age;
        DateTime currentDate = DateTime.Now;
        TimeSpan timeSpan = currentDate - BhirthDate;
        age = timeSpan.Days/365;
        return age;
    }
}
