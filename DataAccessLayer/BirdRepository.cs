using System;
using System.Collections.Generic;
using LinenAndBird.Models;

namespace LinenAndBird.Controllers
{
    public class BirdRepository
    {
        static List<Bird> _birds = new List<Bird>
        {
            new Bird
            {
                Name ="Jimmy",
                Color = "Red",
                Size = "Small",
                Type = BirdType.Dead,
                Accesories = new List<String> { "Beanie", "Converser" }
            }
        };
        internal IEnumerable<Bird> GetAll()
        {
            return _birds;
        }
        internal void Add(Bird newBird)
        {
            _birds.Add(newBird);
        }
    }
}