using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Submission
    {
        [Key]
        [Required]
        public string id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public string CloSure_Date { get; set; }
        public string FinalClosure_Date { get; set; }
    }
}