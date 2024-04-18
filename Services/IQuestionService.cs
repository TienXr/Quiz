using Quiz.Model;

namespace Quiz.Services
{
    public interface IQuestionService
    {

        List<Questions> GetAll();

        List<Questions> GetQuestionsByQuiz(int quizId);

        Questions GetById(int id);

        void Add(Questions question);
    }
}
