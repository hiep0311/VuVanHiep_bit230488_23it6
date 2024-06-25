using System;
using System.Text;

abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    protected string BankAccount { get; set; }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public abstract string GetRole();
}

interface KPIEvaluator
{
    double CalculateKPI();
}

class TeachingAssistant : Person, KPIEvaluator
{
    public string EmployeeID { get; set; }
    private int NumberOfCourses { get; set; }

    public TeachingAssistant(string name, int age, string gender, string employeeID, int numberOfCourses)
        : base(name, age, gender)
    {
        EmployeeID = employeeID;
        NumberOfCourses = numberOfCourses;
    }

    public override string GetRole()
    {
        return "Teaching Assistant";
    }

    public double CalculateKPI()
    {
        return NumberOfCourses * 5;
    }
}

class Lecturer : Person, KPIEvaluator
{
    public string EmployeeID { get; set; }
    private int NumberOfPublications { get; set; }

    public Lecturer(string name, int age, string gender, string employeeID, int numberOfPublications)
        : base(name, age, gender)
    {
        EmployeeID = employeeID;
        NumberOfPublications = numberOfPublications;
    }

    public override string GetRole()
    {
        return "Lecturer";
    }

    public double CalculateKPI()
    {
        return NumberOfPublications * 7;
    }
}

sealed class Professor : Lecturer
{
    public static int CountProfessors = 0;
    private int NumberOfProjects { get; set; }

    public Professor(string name, int age, string gender, string employeeID, int numberOfPublications, int numberOfProjects)
        : base(name, age, gender, employeeID, numberOfPublications)
    {
        NumberOfProjects = numberOfProjects;
        CountProfessors++;
    }

    public override string GetRole()
    {
        return "Professor";
    }

    public new double CalculateKPI()
    {
        return base.CalculateKPI() + NumberOfProjects * 10;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo 1 hoặc 2 đối tượng
        TeachingAssistant ta = new TeachingAssistant("Alice", 25, "Female", "TA001", 3);
        Lecturer lec = new Lecturer("Bob", 40, "Male", "LEC001", 5);
        Professor prof = new Professor("Charlie", 50, "Male", "PROF001", 10, 2);

        PrintPersonInfo(ta);
        PrintPersonInfo(lec);
        PrintPersonInfo(prof);

        // Nhập và hiển thị mảng đối tượng
        Console.WriteLine("Nhập số lượng đối tượng cần tạo (2-10):");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 10)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên từ 2 đến 10:");
        }

        Person[] persons = new Person[n];
        for (int i = 0; i < n; i++)
        {
            persons[i] = InputPerson();
        }

        foreach (var person in persons)
        {
            PrintPersonInfo(person);
        }

        Console.WriteLine($"Số lượng Professors: {Professor.CountProfessors}");
    }

    static void PrintPersonInfo(Person person)
    {
        if (person is KPIEvaluator evaluator)
        {
            Console.WriteLine($"Name: {person.Name}, Role: {person.GetRole()}, KPI: {evaluator.CalculateKPI()}");
        }
    }

    static Person InputPerson()
    {
        Console.WriteLine("Nhập loại đối tượng (ta, lec, gs):");
        string type;
        while (true)
        {
            type = Console.ReadLine().ToLower();
            if (type == "ta" || type == "lec" || type == "gs")
                break;
            Console.WriteLine("Vui lòng nhập lại loại đối tượng (ta, lec, gs):");
        }

        Console.WriteLine("Nhập tên:");
        string name = Console.ReadLine();
        Console.WriteLine("Nhập tuổi:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập giới tính:");
        string gender = Console.ReadLine();
        Console.WriteLine("Nhập mã nhân viên:");
        string employeeID = Console.ReadLine();

        if (type == "ta")
        {
            Console.WriteLine("Nhập số lượng khóa học:");
            int numberOfCourses = int.Parse(Console.ReadLine());
            return new TeachingAssistant(name, age, gender, employeeID, numberOfCourses);
        }
        else if (type == "lec")
        {
            Console.WriteLine("Nhập số lượng bài báo:");
            int numberOfPublications = int.Parse(Console.ReadLine());
            return new Lecturer(name, age, gender, employeeID, numberOfPublications);
        }
        else
        {
            Console.WriteLine("Nhập số lượng bài báo:");
            int numberOfPublications = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số lượng dự án:");
            int numberOfProjects = int.Parse(Console.ReadLine());
            return new Professor(name, age, gender, employeeID, numberOfPublications, numberOfProjects);
        }
    }
}
