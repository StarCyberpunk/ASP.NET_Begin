using System.ComponentModel.DataAnnotations;
namespace SiteWithMySkills.Domain.Entities
{
    public class ServiceItem:EntityBase
    {
        [Required(ErrorMessage ="Заполните название услуши")]
        [Display(Name = "Название услуги")]
        public virtual string Title { get; set; }
        [Display(Name = "Краткое описание услуги")]
        public virtual string Subtitle { get; set; }
        [Display(Name = "Полное описание услуги")]
        public virtual string Text { get; set; }
    }
}
