namespace QuizMVC.Domain.Model
{
    public class QuestionsOnWhichUsersRespondCorrectly
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int QuestionId { get; set; }
    }
}
