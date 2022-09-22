using System.ComponentModel.DataAnnotations;

namespace POC_PremiumInterface.DTOs
{
    public class MappingBankResponseDto
    {
        public int BankId { get; set; }
        public string BankDetail { get; set; }
        public string BankShortName { get; set; }
        public string MappingCode { get; set; }
        public string MappingDetail { get; set; }
        public string Remark { get; set; }
        public bool? IsActive { get; set; }
    }
}