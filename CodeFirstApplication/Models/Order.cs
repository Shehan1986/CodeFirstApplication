using System.ComponentModel.DataAnnotations;

namespace CodeFirstApplication.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderRow> OrderRows { get; set; } = new List<OrderRow>();
    }
}
