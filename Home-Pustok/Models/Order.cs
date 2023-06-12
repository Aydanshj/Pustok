using System.ComponentModel.DataAnnotations;

namespace PustokTemplateTask.Models
{
    public class Order
    {
        public int Id { get; set; }

        [MaxLength(80)]
        public string FullName { get; set; }

        [MaxLength(60)]
        public string Email { get; set; }

        [MaxLength(30)]
        public string Phone { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }


    }
}
