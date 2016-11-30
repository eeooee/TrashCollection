using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using TrashCollection.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollection.Models
{

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Key]
        int ID { get; set; }
        
       public int? customer_ID { get; set; }
        [ForeignKey("customer_ID")]
        public virtual Customers customer { get; set; }
       public int? worker_ID { get; set; }

        [ForeignKey("worker_ID")]
        public virtual Workers workers { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Addresses> addresses { get; set; }
        public DbSet<City> city { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Pickup> pickUp { get; set; }
        public DbSet<States> states { get; set; }
        public DbSet<Vacation> vacation { get; set; }
        public DbSet<Workers> workers { get; set; }
        public DbSet<ZipCodes> zipCodes { get; set; }
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