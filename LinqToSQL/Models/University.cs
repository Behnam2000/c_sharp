namespace LinqToSQL.Models;

public class University
{
    public int Id { get; set; } // Maps to 'id' (int4)
    public string Name { get; set; } // Maps to 'name' (varchar)

    // Navigation Property: One University has many Students[cite: 2]
    public ICollection<Student> Students { get; set; }
}

