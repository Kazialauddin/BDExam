﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModel
{
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
}
