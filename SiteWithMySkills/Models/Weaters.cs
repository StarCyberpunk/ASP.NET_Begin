namespace SiteWithMySkills.Models
{
    public class Weaters
    {
        public int month { get; set; }
        public int year { get; set; }
        public List<Weather> weathersYearMonth = new List<Weather>();
    }
}
