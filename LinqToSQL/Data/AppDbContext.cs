// using Microsoft.EntityFrameworkCore;
// using LinqToSQL.Models;

// namespace LinqToSQL.Data;

// public class AppDbContext : DbContext
// {
//     public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//     {
//     }

//     public DbSet<Student> Students => Set<Student>();

//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         base.OnModelCreating(modelBuilder);

//         modelBuilder.Entity<Student>(entity =>
//         {
//             entity.HasKey(e => e.Id);
//             entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
//             entity.Property(e => e.Gender).IsRequired().HasMaxLength(100);
//         });
//     }
// }
