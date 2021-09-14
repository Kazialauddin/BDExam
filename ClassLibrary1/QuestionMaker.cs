using CoreModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQ
{

    public  class QuestionMaker
    {
        private AppDbContext db = new AppDbContext();
        public List<QuestionViewModel> GetAllQuestions()
        {
            var r = db.questions.ToList();
            var result = (from q in db.questions.ToList()
                         join ans in db.answer.ToList()
                         on q.Id equals ans.QuestionId
                         join opt in db.options.ToList()
                         on ans.OptionId equals opt.Id 
                         select new QuestionViewModel
                         {
                             Qustions = q.Qustions,
                             Answers=ans.Answers,
                             OptionA=opt.OptionA,
                             OptionB=opt.OptionB,
                             OptionC=opt.OptionC,
                             OptionD=opt.OptionD,
                         }).ToList();
            var a = db.answer.ToList();
            var o=db.options.ToList();
            return result;
        }
        public Question GetQuestionDetails(int id)
        {
            return db.questions.Find(id);
        }
        public bool SaveOrUpdate(QuestionViewModel model)
        {




            using (DbContextTransaction transaction = db.Database.BeginTransaction())
            {


                try
                {

                    Question question = new Question();

                    question.Qustions = model.Qustions;
                    db.questions.Add(question);

                    db.SaveChanges();
                    var QID = question.Id;
                    Options options = new Options();
                    options.QuestionId = QID;
                    options.OptionA = model.OptionA;
                    options.OptionB = model.OptionB;
                    options.OptionC = model.OptionC;
                    options.OptionD = model.OptionD;
                    db.options.Add(options);
                    db.SaveChanges();

                    var newOptionId = options.Id;

                    Answer answer = new Answer();
                    answer.QuestionId = QID;
                    answer.OptionId = newOptionId;
                    answer.Answers = model.Answers;


                    db.answer.Add(answer);
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error occurred.");
                }
            }

            return true;
        }
    }

}
