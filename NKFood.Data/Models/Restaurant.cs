using System;
using System.Collections.Generic;
using System.Text;

namespace NKFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType CuisineType { get; set; }
    }

    public enum CuisineType
    {
        None, 
        Italian,
        Indian,
        French
    }

   
}
