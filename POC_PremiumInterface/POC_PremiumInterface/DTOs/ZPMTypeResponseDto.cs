using System.ComponentModel.DataAnnotations;
using System;

namespace POC_PremiumInterface.DTOs
{
    public class ZPMTypeResponseDto
    {
        public int ZPMTypeId { get; set; }
        public string ZPMTypeCode { get; set; }
        public string ZPMTypeDetail { get; set; }
        public bool? IsActive { get; set; }
    }
}