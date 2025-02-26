﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bc_awareness.Models
{
    // a view model class that enables me to pass the question and a list of answer options to the view.
    public class QuestionViewModel
    {
        public Trivia Question { get; set; }
        public List<string> AnswerOptions { get; set; }
        public List<string> ShuffledAnswerOptions { get; set; }

        public QuestionViewModel(Trivia question)
        {
            this.Question = question;
            AnswerOptions = new List<string>();
            this.AnswerOptions.Add(Question.Answer);
            this.AnswerOptions.Add(Question.AnswerOption1);
            this.AnswerOptions.Add(Question.AnswerOption2);
            this.AnswerOptions.Add(Question.AnswerOption3);
            
            Random rnd = new Random();
            ShuffledAnswerOptions = AnswerOptions.OrderBy(i => rnd.Next()).ToList();
            ShuffledAnswerOptions = ShuffledAnswerOptions.OrderBy(i => rnd.Next()).ToList();
        }

    }
}
