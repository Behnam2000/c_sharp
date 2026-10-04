using LinqToSQL.Models;
using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    private readonly AppDbContext _context;

    public StudentController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var students = _context.student.ToList();

        return View(students);
    }
}