using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class View
    {
        [Key]
        [Required]
        public string id { get; set; }
        [DataType("Date")]
        public string last_visited_date { get; set; }
        public virtual ApplicationUser User_ID { get; set; }
        public virtual Idea Idea_ID { get; set; }
    }
}