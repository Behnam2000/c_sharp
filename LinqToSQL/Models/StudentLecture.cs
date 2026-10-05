using LinqToSQL.Models;

public class StudentLecture
{
    public int Id { get; set; } // Explicit Primary Key: Maps to 'id' (int4)[cite: 2]

    // Foreign Key and Navigation to Student[cite: 2]
    public int StudentId { get; set; }// Maps to 'student_id' (int4)[cite: 2]
    public Student? Student { get; set; }


    // Foreign Key and Navigation to Lecture[cite: 2]
    public int LectureId { get; set; } // Maps to 'lecture_id' (int4)[cite: 2]
    public Lecture? Lecture { get; set; }

}