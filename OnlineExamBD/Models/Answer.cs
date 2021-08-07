using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamBD.Models.Questions
{
    //public class Answer
    //{
    //    public int Id { get; set; }//AutoGen
    //    public string Answers { get; set; }
    //    public int QuestionId { get; set; }
    //    public int OptionId { get; set; }
    //}
    public class ModelQA
    {
        public int Id { get; set; }
        public int QNo { get; set; }
        public string Qustions { get; set; }

        public int OptionsId { get; set; }

        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectAns { get; set; }


    }

    public class Question
    {
        public int Id { get; set; }
        public int QNo { get; set; }
        public string Qustions { get; set; }
     
        public int OptionsId { get; set; }

    }
    public class Options
    {
        public int Id { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectAns { get; set; }


    }
}