using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



public class UniversityController : Controller
{
    private readonly AppDbContext _context;

    public UniversityController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var universities = _context.University.Include(u => u.Students.OrderBy(s => s.Name)).OrderBy(u => u.Name).ToList();

        return View(universities);
    }
}