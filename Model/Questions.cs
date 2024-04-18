using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Quiz.Model
{
    public class Questions
    {
        [Key]
        public int Id {  get; set; }
        public required string Question { get; set; }

        [DisplayName("First Choice")]
        public required string FirstChoice { get; set; }

        [DisplayName("Second Choice")]
        public required string SecondChoice { get; set; }

        [DisplayName("Third Choice")]
        public required string ThirdChoice { get; set; }

        [DisplayName("Correct Answer")]
        public int CorrectAnswer {  get; set; }

        [DisplayName("Quiz Id")]
        public int QuizId { get; set; }
    }
}
