using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POC_PremiumInterface.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace POC_PremiumInterface.DTOs
{
    public class ZPMTransactionResponseDto
    {
        public Guid ZPMTransactionId { get; set; }
        public int? ZPMTypeId { get; set; }
        public Guid? QueueId { get; set; }
        public string BatchNo { get; set; }
        public int? ItemCount { get; set; }
        public decimal? Amount { get; set; }
        public int? TransactionStatusId { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string RefFileName { get; set; }
        public bool? IsQueueTransfer { get; set; }
        public virtual ZPMType ZPMType { get; set; }
    }
}