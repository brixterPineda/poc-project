using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace poc_project_Double_Materiality_Assessment.Migrations
{
    /// <inheritdoc />
    public partial class PopulateMaterialIssueDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MaterialIssues",
                columns: new[] { "MaterialIssueId", "IssueCategory", "IssueName" },
                values: new object[,]
                {
                    { 1, "Environmental", "Climate Change" },
                    { 2, "Social", "Data Privacy" },
                    { 3, "Governance", "Corporate Governance" },
                    { 4, "Operational", "Supply Chain Management" },
                    { 5, "Environmental", "Waste Management" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MaterialIssues",
                keyColumn: "MaterialIssueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MaterialIssues",
                keyColumn: "MaterialIssueId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MaterialIssues",
                keyColumn: "MaterialIssueId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MaterialIssues",
                keyColumn: "MaterialIssueId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MaterialIssues",
                keyColumn: "MaterialIssueId",
                keyValue: 5);
        }
    }
}
