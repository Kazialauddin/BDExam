using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    public class Answer
    {
        public int Id { get; set; }
        public string Answers { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
    }

    public class Question
    {
   
        public int Id { get; set; }
        public string Qustions { get; set; }
        //public Answer Answers { get; set; }
        //public Options Options { get; set; }
    }
    public class Options
    {
        public int Id { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public int QuestionId { get; set; }


    }
}
