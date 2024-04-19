using Quiz.Model;

namespace Quiz.Services
{
    public interface IQuestionService
    {

        List<Questions> GetAll();

        List<Questions> GetQuestionsByQuiz(int quizId);

        void Add(Questions question);

        List<int> GetAllQuizId();
    }
}
