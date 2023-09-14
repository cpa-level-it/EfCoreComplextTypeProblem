using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore8Tests.Models
{
    [ComplexType]
    public class CompanyIdentificationData
    {
        public bool Val { get; set; }
        public required BelgiumCompanyIdentificationData Belgium { get; set; } = new() { EntityBceNumber = "", HasVATNumber = true, SeatBceNumber = "" };
    }
}
