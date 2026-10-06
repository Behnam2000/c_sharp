using System.Security.Cryptography;
using LinqToSQL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


public class StudentController : Controller
{
    private readonly AppDbContext _context;

    public StudentController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // .Include() performs a SQL JOIN to get the University data

        var students = _context.Student.Include(s => s.University)
            .Include(s => s.StudentLectures)
                .ThenInclude(sl => sl.Lecture)
        .ToList();

        return View(students);
    }


    // Handles HTTP GET: /Student/Create
    public IActionResult Create()
    {
        return View();
    }


    // Handles HTTP POST: /Student/Create
    [HttpPost]
    [ValidateAntiForgeryToken] // Security feature to prevent Cross-Site Request Forgery (CSRF)
    public IActionResult Create(Student stu)
    {
        // 1. Check if the submitted data is valid based on your model rules
        if (ModelState.IsValid)
        {
            // 2. Add the new object to the EF Core tracking context
            _context.Student.Add(stu);

            // 3. Execute the SQL INSERT statement in PostgreSQL
            _context.SaveChanges();

            // 4. Redirect the browser back to the list view (/Student/Index)
            return RedirectToAction(nameof(Index));
        }

        // If validation failed, return the form view with the data they already type
        return View(stu);

    }

    // Handles HTTP GET: /Student/Enroll
    public IActionResult Enroll()
    {
        // Creates a list of options: the value is "Id", the display text is "Name"
        ViewBag.Student = new SelectList(_context.Student, "Id", "Name");
        ViewBag.Lecture = new SelectList(_context.Lecture, "Id", "Name");

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Enroll(StudentLecture enrollment)
    {
        if (ModelState.IsValid)
        {
            // Optional: Check if this exact enrollment already exists to prevent duplicates
            bool alreadyEnrolled = _context.StudentLecture.Any(sl => sl.StudentId == enrollment.StudentId
            && sl.LectureId == enrollment.LectureId);

            if (!alreadyEnrolled)
            {
                _context.StudentLecture.Add(enrollment);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Enroll));
        }

        // If validation fails, we must repopulate the dropdowns before returning the view
        ViewBag.Student = new SelectList(_context.Student, "Id", "Name", enrollment.StudentId);
        ViewBag.Lecture = new SelectList(_context.Lecture, "Id", "Name", enrollment.LectureId);
        return View(enrollment);
    }



}