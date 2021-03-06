using System.Collections.Generic;

namespace LinenAndBird.Models
{
    public class Bird
    {
        public BirdType Type { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Name { get; set; }
        public List<string> Accesories { get; set; }
    }

    public enum BirdType
    {
        Dead,
        Linen
    }
}
