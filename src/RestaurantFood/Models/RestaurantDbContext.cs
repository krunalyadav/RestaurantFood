using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace RestaurantFood.Models
{
    public class RestaurantDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Restaurants> Restaurants { get; set; }
    }
}