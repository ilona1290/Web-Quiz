﻿namespace QuizMVC.Application.CategoryAndQuestionVm
{
    public class AnswerVm
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }
    }
}
