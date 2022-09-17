using System.ComponentModel.DataAnnotations;

namespace SiteWithMySkills.Domain.Entities
{
    public class Tovar
    {
        [Required(ErrorMessage = "Were is id?")]
        [Display(Name = "Identity")]
        public Guid id { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Цена")]
        public string Price { get; set; }
        [Display(Name = "Описание")]
        public string Opisanie { get; set; }
        [Display(Name = "Категория")]
        public int IdType { get; set; }
        [Display(Name = "Картинка")]
        public string Img { get; set; }
    }
    
}
