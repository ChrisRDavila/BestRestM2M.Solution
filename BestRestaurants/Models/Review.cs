using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Review
    {
        public int ReviewId { get; set; }
        public string Critic { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public List<RestaurantReview> JoinEntities { get;}
    }
}