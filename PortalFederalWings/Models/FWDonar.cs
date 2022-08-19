using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PortalFederalWings.Models
{
    public class FWDonar
    {
        [Key]
        public int ID { get; set; } 
        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string CurrencyCode { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Amount { get; set; }
        
    }
}
