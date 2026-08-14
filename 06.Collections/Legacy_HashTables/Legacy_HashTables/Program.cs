using System;
using System.Collections;
using System.Runtime.Serialization.Formatters;

namespace Legacy_HashTables;

class Program
{
    // Key - Value   
    // Auto - Car

    static void Main(string[] args)
    {
        Hashtable studentsTable = new Hashtable();

        Student stud1 = new Student(1, "Maria", 81);
        Student stud2 = new Student(2, "Bahar", 73);
        Student stud3 = new Student(3, "Behnam", 56);
        Student stud4 = new Student(4, "Bari", 38);

        studentsTable.Add(stud1.Id, stud1);
        studentsTable.Add(stud2.Id, stud2);
        studentsTable.Add(stud3.Id, stud3);
        studentsTable.Add(stud4.Id, stud4);

        // retrieve individual item with known ID
        Student storedStudent1 = (Student)studentsTable[stud1.Id];

        // retrieve all values from a Hashtable ( converting to Student Type )
        foreach (DictionaryEntry entry in studentsTable)
        {
            Student temp = (Student)entry.Value;
            System.Console.WriteLine("Student ID:{0}", temp.Id);
            System.Console.WriteLine("Student Name:{0}", temp.Name);
            System.Console.WriteLine("Student GPA:{0}", temp.GPA);
            System.Console.WriteLine("\n");
        }

        // retrieve all values from a Hashtable ( simlplfied without converting )
        foreach (Student value in studentsTable.Values)
        {
            System.Console.WriteLine("Student ID:{0}", value.Id);
            System.Console.WriteLine("Student Name:{0}", value.Name);
            System.Console.WriteLine("Student GPA:{0}", value.GPA);
            System.Console.WriteLine("\n");
        }



        System.Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2},", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
    }
}

class Student
{
    //property called Id
    public int Id { get; set; }

    public string Name { get; set; }

    public float GPA { get; set; }

    public Student(int id, string name, float GPA)
    {
        this.Id = id;
        this.Name = name;
        this.GPA = GPA;
    }

}
