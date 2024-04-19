using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz.Model;

namespace Quiz.Pages
{
    public class ScoreModel : PageModel
    {
        public string? Score { get; set; }
        public void OnGet()
        {
            Score = TempData["Score"]?.ToString();
            TempData.Remove("Score");
        }
    }
}
