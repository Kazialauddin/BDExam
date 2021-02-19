using OnlineExamBD.Models.Questions;
using OnlineExamBD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace OnlineExamBD.Models
{
    public class AppDbCOntext:DbContext
    {
        public AppDbCOntext() : base("DefaultConnection")
        {
            //www.youtube.com/watch?v=p9GdkmFzoPw
           
        }

        // public DbSet<Questions> Questions { get; set; }
        public DbSet<Answer> answer { get; set; }
        public DbSet<Question> questions { get; set; }
    }
}