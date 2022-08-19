using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PortalFederalWings.Data
{
    public class ApplicationUser : IdentityUser
    {
        [DisplayName("User Code")]
        [Required]
        public string UserCode { get; set; }
    }
}
