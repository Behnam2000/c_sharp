using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinqToSQL.Models;

public class Student
{
    public int Id { get; set; } // Maps to 'id' (int4)[cite: 2]
    public string Name { get; set; } // Maps to 'name' (varchar)[cite: 2]
    public string Gender { get; set; } // Maps to 'gender' (varchar)[cite: 2]

    // The Foreign Key column in PostgreSQL
    public int UniversityId { get; set; } // Maps to 'university_id' (int4)[cite: 2]

    // Navigation property (One Student belongs to one University)
    [ValidateNever] // Ignore validation for the navigation object
    public University? University { get; set; }


    // Navigation Property: Many-to-Many join to Lectures[cite: 2]
    [ValidateNever] // Ignore validation for the collection
    public ICollection<StudentLecture>? StudentLectures { get; set; }
}

