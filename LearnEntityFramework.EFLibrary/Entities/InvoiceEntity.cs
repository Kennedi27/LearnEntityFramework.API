using LearnEntityFramework.EFLibrary.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    public class InvoiceEntity : IAuditableEntity, ISoftDeleteEntity
    {
        public int Id { get; set; }

        [Required]
        public int? CustomerId { get; set; }

        [Required]
        public int PaymentTypeId { get; set; }

        public decimal TotalAmount { get; set; }

        [Range(1, 100)]
        public decimal Discount { get; set; }

        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOnUtc { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeleteTimeUtc { get; set; }
    }
}
