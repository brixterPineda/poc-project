using Microsoft.AspNetCore.Mvc;
using poc_project_Double_Materiality_Assessment.Data;
using poc_project_Double_Materiality_Assessment.Models.Entities;
using System.Diagnostics;

namespace poc_project_Double_Materiality_Assessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbContext;

        // Inject both ILogger and ApplicationDbContext in the constructor
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;

        }

        // The Index action fetches all material issues and passes them to the view
        public IActionResult Index()
        {
            var allIssues = dbContext.MaterialIssues.ToList();
            return View(allIssues);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Questionnaire()
        {
            // Sample list of strings
            var allIssues = dbContext.MaterialIssues.ToList();
            return View(allIssues);
        }



    }
}
