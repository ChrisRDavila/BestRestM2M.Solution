using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class BestRestaurantsContext : DbContext
  {
    public DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<RestaurantTag> RestaurantTags { get; set; }

    public BestRestaurantsContext(DbContextOptions options) : base(options) { }
  }
}