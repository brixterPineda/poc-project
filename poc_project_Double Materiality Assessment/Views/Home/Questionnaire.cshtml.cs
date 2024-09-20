using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace poc_project_Double_Materiality_Assessment.Views.Home
{
    public class Index1Model : PageModel
    {
        private async Task SubmitQuestionnaire()
        {
            // Call API to submit questionnaire
        }

        private async Task SaveForLater()
        {
            // Call API to save responses
        }
        public void OnGet()
        {
        }
    }
}
