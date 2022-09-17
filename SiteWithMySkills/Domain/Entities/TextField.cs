using System.ComponentModel.DataAnnotations;
namespace SiteWithMySkills.Domain.Entities
{
    public class TextField:EntityBase
    {
        [Required]
        public  string CodeWord { get; set; }
        [Display(Name = "Название страницы")]
        public override string Subtitle { get; set; }
        [Display(Name = "Содержание описание")]
        public override string Text { get; set; }
    }
}
