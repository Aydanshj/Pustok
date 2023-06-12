using System.ComponentModel.DataAnnotations;

namespace PustokTemplateTask.Models
{
    public class BookImage
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }

        [MaxLength(200)]
        public string ImageName { get; set; }

        public byte PosterStatus { get; set; }
    }
}
