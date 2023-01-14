using LearnEntityFramework.EFLibrary.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("receive_product")]
    public class ReceiveProductEntity : IAuditableEntity, ISoftDeleteEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }

        [Required]
        public int SupplierId { get; set; }

        public bool Deleted { get; set; }
        public DateTime? DeleteTimeUtc { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOnUtc { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
    }
}
