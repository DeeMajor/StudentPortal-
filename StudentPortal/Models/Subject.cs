using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public DateTime Year { get; set; }
        public int Term { get; set; }
        public int paperNo { get; set; }
    }
}