using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace University.Models
{
    public class Department
    {
        [Required]
        [Key]
        public string id { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}