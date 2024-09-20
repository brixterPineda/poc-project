using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using poc_project_Double_Materiality_Assessment.Models;

namespace poc_project_Double_Materiality_Assessment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<poc_project_Double_Materiality_Assessment.Models.Stakeholder> Stakeholder { get; set; } = default!;
    }
}
