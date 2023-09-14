using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore8Tests.Models
{
    [ComplexType]
    public class BelgiumCompanyIdentificationData : BaseCompanyIdentificationData<BelgiumCompanyIdentificationData>
    {
        public required string SeatBceNumber { get; set; }
        public required string EntityBceNumber { get; set; }
        public required bool HasVATNumber { get; set; }
    }

}
