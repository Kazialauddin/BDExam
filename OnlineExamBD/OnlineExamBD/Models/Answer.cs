using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamBD.Models.Questions
{
    public class Answer
    {
        public int Id { get; set; }
        public string Answers { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }
        public string Qustions { get; set; }
    }
}