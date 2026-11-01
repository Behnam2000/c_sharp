using LinqToSQL.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Student> Student { get; set; }
    public DbSet<University> University { get; set; }
    public DbSet<Lecture> Lecture { get; set; }
    public DbSet<StudentLecture> StudentLecture { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure One-to-Many: University -> Student[cite: 2]
        modelBuilder.Entity<Student>()
            .HasOne(s => s.University)
            .WithMany(u => u.Students)
            .HasForeignKey(s => s.UniversityId);

        // Configure Many-to-Many via Join Entity: Student <-> Lecture[cite: 2]
        modelBuilder.Entity<StudentLecture>()
        .HasOne(sl => sl.Student)
        .WithMany(s => s.StudentLectures)
        .HasForeignKey(sl => sl.StudentId);

        modelBuilder.Entity<StudentLecture>()
        .HasOne(sl => sl.Lecture)
        .WithMany(l => l.StudentLectures)
        .HasForeignKey(sl => sl.LectureId);
    }
}