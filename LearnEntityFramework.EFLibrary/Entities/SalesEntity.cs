﻿using LearnEntityFramework.EFLibrary.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("sales")]
    public class SalesEntity: IAuditableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int InvoiceId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOnUtc { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
    }
}
