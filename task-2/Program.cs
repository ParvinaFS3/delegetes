using System;
using System.Collections.Generic;

class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

class Student : Human
{
    public int? Grade { get; set; }
}

class Employee : Human
{
    public string Position { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();
    static List<Employee> employees = new List<Employee>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Student əlavə et");
            Console.WriteLine("2. Employee əlavə et");
            Console.WriteLine("3. Axtarış et");
            Console.WriteLine("4. Çıxış");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AddEmployee();
                    break;
                case "3":
                    SearchMenu();
                    break;
                case "4":
                    Console.WriteLine("Proqram sonlandırılır.");
                    return;
                default:
                    Console.WriteLine("Yanlış seçim! Zəhmət olmasa, doğru bir seçim edin.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Adı daxil edin: ");
        string name = Console.ReadLine();

        Console.Write("Soyadı daxil edin: ");
        string surname = Console.ReadLine();

        Console.Write("Yaşı daxil edin: ");
        int age = int.Parse(Console.ReadLine());

        students.Add(new Student { Name = name, Surname = surname, Age = age, Grade = null });
        Console.WriteLine("Student əlavə edildi.");
    }

    static void AddEmployee()
    {
        Console.Write("Adı daxil edin: ");
        string name = Console.ReadLine();

        Console.Write("Soyadı daxil edin: ");
        string surname = Console.ReadLine();

        Console.Write("Yaşı daxil edin: ");
        int age = int.Parse(Console.ReadLine());

        employees.Add(new Employee { Name = name, Surname = surname, Age = age, Position = null });
        Console.WriteLine("Employee əlavə edildi.");
    }

    static void SearchMenu()
    {
        Console.WriteLine("\n1. Employe üzrə axtarış");
        Console.WriteLine("2. Student üzrə axtarış");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SearchEmployeeByPosition();
                break;
            case "2":
                SearchStudentByGrade();
                break;
            default:
                Console.WriteLine("Yanlış seçim! Zəhmət olmasa, doğru bir seçim edin.");
                break;
        }
    }

    static void SearchEmployeeByPosition()
    {
        Console.Write("Axtarmaq istədiyiniz vəzifəni daxil edin: ");
        string position = Console.ReadLine();

        var matchingEmployees = employees.FindAll(e => e.Position == position);

        Console.WriteLine("Uyğun vəzifədə olan Employe-lər:");
        foreach (var employee in matchingEmployees)
        {
            Console.WriteLine($"{employee.Name} {employee.Surname}");
        }
    }

    static void SearchStudentByGrade()
    {
        Console.Write("Minimum Grade daxil edin: ");
        int minGrade = int.Parse(Console.ReadLine());

        Console.Write("Maximum Grade daxil edin: ");
        int maxGrade = int.Parse(Console.ReadLine());

        var matchingStudents = students.FindAll(s => s.Grade >= minGrade && s.Grade <= maxGrade);

        Console.WriteLine($"{minGrade} və {maxGrade} aralığında olan Student-lər:");
        foreach (var student in matchingStudents)
        {
            Console.WriteLine($"{student.Name} - Grade: {student.Grade}");
        }
    }
}








