namespace BestRestaurants.Models
{
  public class RestaurantReview
    {       
        public int RestaurantReviewId { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}