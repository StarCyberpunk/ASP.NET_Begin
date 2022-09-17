using System.ComponentModel.DataAnnotations;

namespace SiteWithMySkills.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }
        [Display(Name ="Название заголовок")]
        public virtual string Title { get; set; }
        [Display(Name = "Краткое описание")]
        public virtual string Subtitle { get; set; }
        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }
        [Display(Name = "Картинка")]
        public virtual string TitleImagePath { get; set; }
        [Display(Name = "SeoTag")]
        public virtual string SeoTag { get; set; }
        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

    }
}
