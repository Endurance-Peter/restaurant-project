using NKFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NKFood.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class INMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public INMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ Id =1, Name="Scottish Pizza", CuisineType= CuisineType.French},
                new Restaurant{ Id =2, Name="Mango Grove", CuisineType= CuisineType.Italian},
                new Restaurant{ Id =3, Name="Tersiguels", CuisineType= CuisineType.Indian},
                new Restaurant{ Id =4, Name="Ken Pizza", CuisineType= CuisineType.French}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(x => x.Name);
        }
    }
}
