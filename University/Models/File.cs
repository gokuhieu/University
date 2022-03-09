using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class File
    {
        [Key]
        [Required]
        public string ID { get; set; }
        public string File_path { get; set; }
        public string Created_Date { get; set; }
        public string Modified_Date { get; set; }
        public virtual Idea Idead_ID { get; set; }
    }
}