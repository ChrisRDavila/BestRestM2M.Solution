using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    [Required(ErrorMessage = "The restaurant name can't be empty.")]
    public string Name { get; set; }  
    [Range(1, int.MaxValue, ErrorMessage = "You must add your restaurant to a cuisine. Have you created a cuisine yet?")]
    public int CuisineId { get; set; }
    public Cuisine Cuisine { get; set; }
    public List <RestaurantTag> JoinEntities { get; }
  }
}