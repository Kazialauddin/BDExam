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
            //"https://www.youtube.com/watch?v=p9GdkmFzoPw"
        }
    }
}