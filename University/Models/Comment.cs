using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Comment
    {
        [Key]
        [Required]
        public string id { get; set; }
        public string content { get; set; }
        public string created_Date { get; set; }
        public virtual ApplicationUser User_ID { get; set; }
        public virtual Idea Idea_ID { get; set; }
    }
}