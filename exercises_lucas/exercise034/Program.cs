public enum Gender
{
    m,
    f,
    x,
}
public abstract class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public string Address { get; set; }

    public string getGender(Gender gender)
    {
        string returnGender = gender switch
        {
            Gender.m => "male",
            Gender.f => "female",
            Gender.x => "diverse",
        };
        return returnGender;
    }

    public Gender Gender { get; set; }

    public Human(string name, int age, Gender gender, string address)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Address = address;
    }

    public Human()
    {

    }
}

public class Dozent : Human
{
    public string University { get; set; }
    public int Salary { get; set; }

    public Dozent(string name, int age, Gender gender, string address, string university, int salary) 
    {
        Name = name;
        Age = age;
        Gender=gender;
        Address= address;
        University = university;
        Salary = salary;
    }
}

public class Student : Human
{
    public int StudentNo { get; set; }
    public string University { get; set; }
    public List<string> Courses { get; set; }

    public Student(string name, int age, Gender gender, string address, int studentNo, string university, List<string> courses)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Address = address;
        StudentNo = studentNo;
        University = university;
        Courses = courses;
    }
}

public class Visitor : Human
{
    public Visitor(string name, int age, Gender gender, string address) 
    {
        Name = name;
        Age = age;
        Gender = gender;
        Address = address;
    }
}