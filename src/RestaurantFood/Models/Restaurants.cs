using Utilities.Enum;

namespace RestaurantFood.Models
{
    public class Restaurants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}
