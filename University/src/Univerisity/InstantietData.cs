using System.Xml;
using Univerisity.Enumuration;

namespace Univerisity;

public static class InstantietData
{
    public static Dictionary<int, Lecturer> LecturerList(){
        return new Dictionary<int, Lecturer>(){
            {1, new Lecturer("312008912111988002", "T701","Antik","Haya",Gender.Female,new DateTime(1988, 11, 12),"Jakarta", 36, TypeBlood.A, Religion.Islam, 6_500_000, new DateTime(2016, 03, 16),new List<Course>(){
                new Course("Infrastructure Design"),
                new Course("Network Security")
            })
            },
            {2, new Lecturer("312008907011989002", "T808","Cahya","Subroto",Gender.Male,new DateTime(1989, 01, 07),"Surabaya", 60, TypeBlood.B, Religion.Islam, 8_800_00, new DateTime(2016, 04, 4),new List<Course>(){
                new Course("Object Oriented Programming"),
                new Course("Java Fundamental"),
                new Course("Database Fundametal")
            })
            }
        };
    }

    public static Dictionary<string, Student> StudentList(){
        return new Dictionary<string, Student>(){
            {"A021", new Student("312008923111990002","A021","Alex","Wirianata", Gender.Male,new DateTime(1990, 12, 23), "Jakarta",33,TypeBlood.A,Religion.Kristen,new DateTime(2018, 04, 12),new List<CourseTaken>(){
               new CourseTaken("Object Oriented Programming","Programming",new DateTime(2018, 04, 12), new DateTime(2018, 09, 18), "", 20),
               new CourseTaken("Data Structure", "Programming", new DateTime(2018, 08, 18), null,"",30)
            })
            },
            {"A022", new Student("312008911051995002", "A022", "Desy", "Oktaviany", Gender.Female, new DateTime(1995, 05, 11), "Bandung", 28, TypeBlood.B, Religion.Islam, new DateTime(2018, 04, 1), new List<CourseTaken>(){
                new CourseTaken("Networking Fundamental", "Networking", new DateTime(2018, 04, 1), null, "",20),
                new CourseTaken("Data Structure", "Programming", new DateTime(2018, 08, 18), null, "",30)
            })
            },
            {"A023", new Student("3120089277889990002", "A023", "Joko", "Davinson", Gender.Male, new DateTime(1990, 06, 7), "Jakarta", 33,TypeBlood.A, Religion.Islam, new DateTime(2018, 04, 14), new List<CourseTaken>(){
                new CourseTaken("Unified Modeling Language", "Management and Aalysis", new DateTime(2018, 05, 3), new DateTime(2018, 11, 1), "",20)
            })}
        };
    }
}
