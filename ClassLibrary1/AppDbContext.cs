﻿

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CoreModel;

namespace ServiceQ
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {
            //www.youtube.com/watch?v=p9GdkmFzoPw

        }

        // public DbSet<Questions> Questions { get; set; }77
        public DbSet<Answer> answer { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Options> options { get; set; }
    }
}
