using System.ComponentModel.DataAnnotations;

namespace PustokTemplateTask.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        public ICollection<BookTag> BookTags { get; set; }
    }
}
