using Microsoft.EntityFrameworkCore;
using RestaurantRaterAPI.Models;

namespace RestaurantRaterAPI
{
    public class RestaurantDbContext
    {
         public class RestaurantDBContext:DbContext
    {
        public RestaurantDBContext(DbContextOptions<RestaurantDBContext>options):base(options){}
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
    }
}