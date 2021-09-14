using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Questions
    {
        public int Id { get; set; }
        public int QNo { get; set; }
        public string Qustions { get; set; }

        public int OptionsId { get; set; }

    }
}
