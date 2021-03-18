using System.Collections.Generic;

namespace QuizMVC.Domain.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int CategoryId { get; set; }
        public bool IsAccepted { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
