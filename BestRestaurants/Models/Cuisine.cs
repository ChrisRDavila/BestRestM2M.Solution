using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    [Required(ErrorMessage = "The category type can't be empty.")]
    public string Type { get; set; }
    public List<Restaurant> Restaurants { get; set; }
  }
}