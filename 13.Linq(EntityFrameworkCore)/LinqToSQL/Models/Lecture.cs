using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinqToSQL.Models;

public class Lecture
{
    public int Id { get; set; } // Maps to 'id' (int4)[cite: 2]
    public string? Name { get; set; } // Maps to 'name' (varchar)[cite: 2]


    // Navigation Property: Many-to-Many join to Students[cite: 2]
    [ValidateNever]
    public ICollection<StudentLecture>? StudentLectures { get; set; }


}