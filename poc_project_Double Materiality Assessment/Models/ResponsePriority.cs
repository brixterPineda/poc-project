namespace poc_project_Double_Materiality_Assessment.Models
{
    public class ResponsePriority
    {
        public int ResponseId { get; set; }
        public int StakeholderId { get; set; }
        public Stakeholder Stakeholder { get; set; }
        public int IssueId { get; set; }
        public MaterialIssue Issue { get; set; }
        public int PriorityRank { get; set; }

    }
}
