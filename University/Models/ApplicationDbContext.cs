using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
namespace University.Models
{
   

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        { 
        }

        public static ApplicationDbContext Create()
        {
            
            return new ApplicationDbContext();
        }
        public System.Data.Entity.DbSet<University.Models.Department> department_ID { get; set; }
        public System.Data.Entity.DbSet<University.Models.Comment> Commet_ID { get; set; }
        public System.Data.Entity.DbSet<University.Models.File> File_ID { get; set; }
        public System.Data.Entity.DbSet<University.Models.Idea> Idea_ID { get; set; }
        public System.Data.Entity.DbSet<University.Models.Submission> SubMS_ID { get; set; }
        public System.Data.Entity.DbSet<University.Models.View> View_ID { get; set; }
        public System.Data.Entity.DbSet<University.Models.Category> Category_ID { get; set; }
    }
}