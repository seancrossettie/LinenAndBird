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
              Style = Hat.HatStyle.OpenBack
          }
        };

        internal List<Hat> GetAll()
        {
            return _hats;
        }

        internal void Add(Hat newHat)
        {
            throw new NotImplementedException();
        }

        internal static object GetByStyle(Hat.HatStyle style)
        {
            _hats.Where(hat => hat.Style == style);
        }
    }
}