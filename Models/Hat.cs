namespace LinenAndBird.Models
{
    public class Hat
    {
        public string Designer { get; set; }
        public string Color { get; set; }
        public HatStyle Style { get; set; }
    }
    public enum HatStyle
    {
        Normal,
        OpenBack,
        WideBrim
    }
}