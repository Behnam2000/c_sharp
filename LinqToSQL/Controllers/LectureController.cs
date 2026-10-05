using LinqToSQL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class LectureController : Controller
{
    private readonly AppDbContext _context;

    public LectureController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var lectures = _context.Lecture.Include(s => s.StudentLectures).ToList();

        return View(lectures);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Lecture lecture)
    {
        if (ModelState.IsValid)
        {
            _context.Lecture.Add(lecture);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        return View(lecture);
    }

    public IActionResult Details(int id)
    {
        var lecture = _context.Lecture
            .Include(l => l.StudentLectures)    // 1. Fetch the mapping rows
                .ThenInclude(sl => sl.Student) // 2. Fetch the Student for each mapping
            .FirstOrDefault(l => l.Id == id); // 3. Find the specific lecture

        if (lecture == null)
        {
            return NotFound();
        }

        return View(lecture);
    }
}
