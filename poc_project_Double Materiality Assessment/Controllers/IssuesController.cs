using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using poc_project_Double_Materiality_Assessment.Data;
using poc_project_Double_Materiality_Assessment.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poc_project_Double_Materiality_Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public IssuesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
       
        public IActionResult GetAllIssues()
        {
            var allIssues = dbContext.MaterialIssues.ToList();

            return Ok(allIssues);
        }
    }
}
