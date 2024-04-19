using Quiz.Context;
using Quiz.Model;

namespace Quiz.Services
{
    public class QuestionService : IQuestionService
    {
        private AppDbContext _context { get; set; }

        public QuestionService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Questions question)
        {
            _context.Question.Add(question);
            _context.SaveChanges();
        }

        public List<Questions> GetAll() => _context.Question.ToList();

        public List<Questions> GetQuestionsByQuiz(int quizId)
        {
            return [.. _context.Question.Where(q => q.QuizId == quizId)];
        }

        public List<int> GetAllQuizId()
        {
            return [.. _context.Question.Select(q => q.QuizId).Distinct()];
        }
    }
}
