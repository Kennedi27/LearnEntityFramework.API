using LearnEntityFramework.EFLibrary.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    public class CustomerEntity : ISoftDeleteEntity, IAuditableEntity
    {
        [Required]
        public long Id { get; set; }
        [MaxLength(20)]
        public string Code { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(15)]
        public string? Contact { get; set; }
        [MaxLength(200)]
        public string? Address { get; set; }

        public string CreatedBy { get; set; } = String.Empty;

        public DateTime CreatedOnUtc { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedOnUtc { get; set; }

        public bool Deleted { get; set; }
        
        public DateTime? DeleteTimeUtc { get; set; }
    }
}
