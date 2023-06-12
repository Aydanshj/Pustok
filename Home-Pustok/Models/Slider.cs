using System.ComponentModel.DataAnnotations;

namespace PustokTemplateTask.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Image { get; set; }

        [MaxLength(50)]
        public string FirstTitle { get; set; }

        [MaxLength(50)]
        public string SecondTitle { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }

        [MaxLength(120)]
        public string BtnUrl { get; set; }

        [MaxLength(30)]
        public string BtnText { get; set; }
    }
}
