namespace BestRestaurants.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Score { get; set; }

    public string Name { get; set; }
    public int RestaurantId { get; set; }
    // navigation property
    public Restaurant Restaurant { get; set; }


  }
}