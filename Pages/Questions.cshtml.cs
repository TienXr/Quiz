using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz.Model;
using Quiz.Services;

namespace Quiz.Pages
{
    public class QuestionsModel : PageModel
    {
        [BindProperty]
        public Questions? Question { get; set; }

        private IQuestionService _service { get; set; }

        public QuestionsModel(IQuestionService service)
        {
            _service = service;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Add(Question);

            return Redirect("/Quizes");
        }
    }
}
