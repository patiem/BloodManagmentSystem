using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BloodManagmentSystem.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BloodRequest> Requests { get; set; }
        public DbSet<BloodBank> Banks { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}