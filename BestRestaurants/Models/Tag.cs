using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Tag
    {
        public int TagId { get; set; }
        public string Description { get; set; }
        public List<RestaurantTag> JoinEntities { get;}
    }
}