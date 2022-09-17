using System.ComponentModel.DataAnnotations;
namespace SiteWithMySkills.Models
{
    public class Message
    {
        [Required(ErrorMessage = "Were is id?")]
        [Display(Name = "Identity")]
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Messages { get; set; }
    }
}
