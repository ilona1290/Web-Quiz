namespace QuizMVC.Domain.Model
{
    public class Score
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public int BestResult { get; set; }
        public int CurrentResult { get; set; }
        public int Place { get; set; }
    }
}
