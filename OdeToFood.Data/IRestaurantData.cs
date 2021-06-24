using OdeToFood.Core;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1, Name="Domino's Pizza", Location="Delhi", Cuisine=CuisineType.Italian},
                new Restaurant{Id=2, Name="Persiaon Darbar", Location="Mumbai", Cuisine=CuisineType.Indian},
                new Restaurant{Id=3, Name="Food Inn", Location="Bhiwandi", Cuisine=CuisineType.Mexican}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
