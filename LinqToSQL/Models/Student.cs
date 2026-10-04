namespace LinqToSQL.Models;

public class Student
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string? gender { get; set; }
    public int university_id { get; set; }
}

