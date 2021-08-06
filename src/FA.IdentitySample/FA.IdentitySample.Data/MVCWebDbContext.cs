using System.Data.Entity;
using FA.IdentitySample.Models.Common;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FA.IdentitySample.MVCWeb.Models
{
    public class MVCWebDbContext : IdentityDbContext<User>
    {
        public MVCWebDbContext()
            : base("AspNetIdentityConnection", throwIfV1Schema: false)
        {
        }

        static MVCWebDbContext()
        {
            // Set the database initializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            Database.SetInitializer<MVCWebDbContext>(new ApplicationDbInitializer());
        }

        public static MVCWebDbContext Create()
        {
            return new MVCWebDbContext();
        }
    }
}