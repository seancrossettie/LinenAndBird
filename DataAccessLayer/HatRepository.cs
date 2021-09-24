using System;
using System.Collections.Generic;
using System.Linq;
using LinenAndBird.Models;

namespace LinenAndBird.DataAccesLayer
{   
    public class HatRepository
    {
        static List<Hat> _hats = new List<Hat>
        {
          new Hat
          {
              Color = "Blue",
              Designer = "Someone",
              Style = HatStyle.OpenBack
          }
        };

        internal List<Hat> GetAll()
        {
            return _hats;
        }

        internal void Add(Hat newHat)
        {
            _hats.Add(newHat);
        }

        internal IEnumerable<Hat> GetByStyle(HatStyle style)
        {
           return _hats.Where(hat => hat.Style == style);
        }
    }
}