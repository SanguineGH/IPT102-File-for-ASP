using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Jesse James B. Liccud", StudentId = "S001", StudentAge = "20", StudentGrade = "1" },
            new StudentInfoModel { Name = "Levina B. Liccud", StudentId = "S002", StudentAge = "31", StudentGrade = "1" },
            new StudentInfoModel { Name = "Jimmy T. Liccud", StudentId = "S003", StudentAge = "31", StudentGrade = "1" },
            new StudentInfoModel { Name = "Test Subject", StudentId = "S004", StudentAge = "56", StudentGrade = "1" }
        };

        return View(studentInfoArray);
    }
}
