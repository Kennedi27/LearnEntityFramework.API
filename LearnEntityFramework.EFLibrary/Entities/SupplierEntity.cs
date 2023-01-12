
using LearnEntityFramework.EFLibrary.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("supplier")]
    public class SupplierEntity : IAuditableEntity, ISoftDeleteEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required, MaxLength(20)]
        public string Code { get; set; } = String.Empty;
        
        [Required, MaxLength(50)]
        public string Name { get; set; } = String.Empty;
        
        [Required, MaxLength(15)]
        public string Contact { get; set; } = String.Empty;
        
        [Required, MaxLength(20)]
        public string Address { get; set; } = String.Empty;
        
        [Required, MaxLength(50)] 
        public string Email { get; set; } = String.Empty;
        public bool Deleted { get; set; }
        public DateTime? DeleteTimeUtc { get; set; }

        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOnUtc { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
    }
}
