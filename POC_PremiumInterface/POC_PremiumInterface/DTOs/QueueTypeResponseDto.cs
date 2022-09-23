using System.ComponentModel.DataAnnotations;
using System;

namespace POC_PremiumInterface.DTOs
{
    public class QueueTypeResponseDto
    {
        public int QueueTypeId { get; set; }
        public string QueueTypeDetail { get; set; }
        public bool? IsActive { get; set; }
        /*        public DateTime? CreatedDate { get; set; }
                public int? CreatedByUserId { get; set; }*/
    }
}