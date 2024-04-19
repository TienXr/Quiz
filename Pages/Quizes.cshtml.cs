using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz.Model;
using Quiz.Services;

namespace Quiz.Pages
{
    public class QuizesModel : PageModel
    {
        public List<Questions> Question { get; set; }

        public List<int> QuizNum { get; set; }

        private IQuestionService _service { get; set; }

        public QuizesModel(IQuestionService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            QuizNum = _service.GetAllQuizId();
        }

        public IActionResult OnGetGetQuestions(int quizId)
        {
            Question = _service.GetQuestionsByQuiz(quizId);
            return new JsonResult(Question);
        }

        public IActionResult OnPost()
        {
            int correctCount = 0;
            foreach (var key in Request.Form.Keys)
            {
                var value = Request.Form[key];
                Console.WriteLine($"Key: {key}, Value: {value}");
            }

            foreach (var key in Request.Form.Keys)
            {
                if (key.StartsWith("choice-"))
                {
                    int selectedChoice;
                    if (int.TryParse(Request.Form[key], out selectedChoice))
                    {
                        int questionId = int.Parse(key.Split('-')[1]);
                        int correctAnswer = int.Parse(Request.Form[$"{questionId}-correctAnswer"]);
                        if (selectedChoice == correctAnswer)
                        {
                            correctCount++;
                        }
                    }
                }
            }
            TempData["Score"] = correctCount;
            return RedirectToPage("/Score");
        }
    }
}
