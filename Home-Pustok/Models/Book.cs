using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokTemplateTask.Models
{
    public class Book
    {
        public int Id{ get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }    

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public byte StockStatus { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal DiscountPercent { get; set;}

        [MaxLength(1000)]
        public string Description { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal CostPrice { get; set; }

        public byte IsNew { get; set; }

        public byte IsFeatured { get; set; }

        public ICollection<BookImage> Images { get; set;}

        public ICollection<BookTag> BookTags { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
