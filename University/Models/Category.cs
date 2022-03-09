using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Category
    {
        [Key]
        [Required]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}