namespace QuizMVC.Domain.Model
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsAccepted { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
