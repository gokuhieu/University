using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Idea
    {
        [Key]
        [Required]
        public string Idea_ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Created_Date { get; set; }
        public string Last_Modified_Date { get; set; }
        public virtual ApplicationUser User_ID { get; set; }
        public virtual Category Category_ID{ get; set; }
        public virtual Submission Submisson_ID { get; set; }
    }
}