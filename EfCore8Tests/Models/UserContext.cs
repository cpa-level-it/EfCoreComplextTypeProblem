using System.ComponentModel.DataAnnotations;

namespace EfCore8Tests.Models
{
    public class UserContext
    {
        public int Id { get; set; }

        [Required]
        public required CompanyIdentificationData CompanyIdentificationData { get; set; } = new() { Belgium = null, Val = true };
    }
}
