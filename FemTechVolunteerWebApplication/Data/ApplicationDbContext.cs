using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FemTechVolunteerWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<AdminUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //The line below translates to a Volunteers table being created in the database
        public DbSet<Volunteer> Volunteers { get; set; }
    }
}