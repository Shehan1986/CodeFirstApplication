using System.ComponentModel.DataAnnotations;

namespace CodeFirstApplication.Models
{
    public class OrderRow
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int MovieId { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        public virtual Order Order { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
