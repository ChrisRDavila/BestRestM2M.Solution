using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BestRestaurants.Models
{
  public class Tag
    {
        public int TagId { get; set; }
        [Required(ErrorMessage = "The Tag description can't be empty.")]
        public string Description { get; set; }
        public List<RestaurantTag> JoinEntities { get;}
    }
}