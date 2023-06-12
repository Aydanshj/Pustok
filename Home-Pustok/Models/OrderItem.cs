using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokTemplateTask.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int Count { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal UnitSalePrice { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal UnitCostPrice { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal UnitDiscountPercent { get; set; }
    }
}
