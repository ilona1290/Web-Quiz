using System.Collections.Generic;

namespace QuizMVC.Domain.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAccepted { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
