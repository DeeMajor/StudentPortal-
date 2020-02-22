using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    public class Career
    {
        public int CareerId { get; set; }
        public string Name { get; set; }

        public string Requirements { get; set; }
        public string Experience { get; set; }
    }
}