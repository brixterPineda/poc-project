using Microsoft.EntityFrameworkCore;
using poc_project_Double_Materiality_Assessment.Models.Entities;

namespace poc_project_Double_Materiality_Assessment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Stakeholder> Stakeholders { get; set; } = default!;
        public DbSet<MaterialIssue> MaterialIssues { get; set; } = default!;
        public DbSet<ResponsePriority> ResponsePriorities { get; set; } = default!;
        public DbSet<ResponseRelevance> ResponseRelevances { get; set; } = default!;
        public DbSet<AdditionalIssue> AdditionalIssues { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting up AdditionalIssue
            modelBuilder.Entity<AdditionalIssue>()
                .HasKey(ai => ai.IssueId); // Set IssueId as the primary key

            modelBuilder.Entity<AdditionalIssue>()
                .HasOne(ai => ai.Stakeholder);

            modelBuilder.Entity<ResponseRelevance>()
              .HasKey(rr => rr.ResponsePriorityId);


        }
    }
}
