using System.ComponentModel.DataAnnotations;

namespace PustokTemplateTask.Models
{
    public class Author
    {
        public int Id { get; set; }

        [MaxLength(80)]
        public string FullName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
