using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApplication.Models
{
    public class Movie
    { 
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Director { get; set; }

        [Required]
        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [Required]
        public string Genre { get; set; }
        public virtual ICollection<OrderRow> OrderRows { get; set; } = new List<OrderRow>();
    }
}
