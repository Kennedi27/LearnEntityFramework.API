
using LearnEntityFramework.EFLibrary.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("purchase_order")]
    public class PurchaseOrderEntity : IAuditableEntity
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
    }
}
