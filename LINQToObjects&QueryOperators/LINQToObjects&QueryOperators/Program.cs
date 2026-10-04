using System.Data.Common;

namespace LINQToObjects_QueryOperators;

class Program
{
    static void Main(string[] args)
    {
        UniversityManager um = new UniversityManager();

        um.MaleStudents();
        um.FemaleStudents();
        um.SortStudentByAge();
        um.AllStudentsFromBeijingTech();
        um.StudentAndUniversityNameCollection();

        //________________________________________________________________________________________

        // Sort and Reverse integers (fast and simple)
        int[] someInt = { 30, 12, 4, 3, 12 };
        IEnumerable<int> sortedInt = from i in someInt orderby i select i;
        IEnumerable<int> reversedInt = sortedInt.Reverse();

        foreach (int i in reversedInt)
        {
            System.Console.WriteLine(i);
        }

        // Reverse alternative way:
        IEnumerable<int> reversedSortedInts = from i in someInt orderby i descending select i;

        //________________________________________________________________________________________



        /*
        System.Console.WriteLine("\nEnter University ID to show the students: ");
        string userInputUni = Console.ReadLine()!;

        try
        {
            int userInputUniInt = Convert.ToInt32(userInputUni);

            um.AllStudentsFromUniId(userInputUniInt);
        }
        catch (Exception)
        {
            System.Console.WriteLine("Wrong Value");
        }*/


    }
}

class Univesity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public void Print()
    {
        System.Console.WriteLine($"University {Name} with id {Id}");
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    // Foreign Key
    public int UniversityId { get; set; }

    public void Print()
    {
        System.Console.WriteLine($"Student {Name} with id: {Id}\nGender: {Gender}\nAge: {Age}\nFrom University id: {UniversityId}\n");
    }
}


class UniversityManager
{
    public List<Univesity> universities;
    public List<Student> students;

    // constructor
    public UniversityManager()
    {
        universities = new List<Univesity>();
        students = new List<Student>();

        universities.Add(new Univesity { Id = 1, Name = "yale" });
        universities.Add(new Univesity { Id = 2, Name = "Beijing Tech" });

        students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 18, UniversityId = 1 });
        students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
        students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
        students.Add(new Student { Id = 4, Name = "James", Gender = "male", Age = 25, UniversityId = 2 });
        students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
    }

    public void MaleStudents()
    {
        IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
        System.Console.WriteLine("\nMale - Students: ");
        foreach (Student student in maleStudents)
        {
            student.Print();
        }
    }

    public void FemaleStudents()
    {
        IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
        System.Console.WriteLine("\nFemale - Students: ");
        foreach (Student student in femaleStudents)
        {
            student.Print();
        }
    }

    public void SortStudentByAge()
    {
        var sortedStudents = from student in students orderby student.Age select student;

        System.Console.WriteLine("\nStudent sorted by Age: ");

        foreach (Student student in sortedStudents)
        {
            student.Print();
        }
    }

    public void AllStudentsFromBeijingTech()
    {
        IEnumerable<Student> bjtStudents = from student in students
                                           join university in universities on student.UniversityId equals university.Id
                                           where university.Name == "Beijing Tech"
                                           select student;

        System.Console.WriteLine("\nStudents from Beijin Tech: ");

        foreach (Student student in bjtStudents)
        {
            student.Print();
        }
    }

    public void AllStudentsFromUniId(int id)
    {
        IEnumerable<Student> myStudents = from student in students
                                          join university in universities on student.UniversityId equals university.Id
                                          where university.Id == id
                                          select student;

        System.Console.WriteLine("\nSearch Result: ");

        foreach (Student stu in myStudents)
        {
            stu.Print();
        }
    }

    public void StudentAndUniversityNameCollection()
    {
        var newCollection = from student in students
                            join university in universities on student.UniversityId equals university.Id
                            orderby student.Name
                            select new { StudentName = student.Name, UniversityName = university.Name };


        System.Console.WriteLine("New Collections: \n");

        foreach (var col in newCollection)
        {
            System.Console.WriteLine($"Student {col.StudentName} from University: {col.UniversityName}");
        }
    }



}


