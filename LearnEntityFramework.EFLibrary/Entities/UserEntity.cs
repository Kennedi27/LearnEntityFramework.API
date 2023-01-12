using LearnEntityFramework.EFLibrary.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("user")]
    public class UserEntity : IAuditableEntity, ISoftDeleteEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string FirstName { get; set; } = String.Empty;

        [Required, MaxLength(20)]
        public string UserName { get; set; } = String.Empty;

        [Required, MaxLength(20)]
        public string LastName { get; set; } = String.Empty;

        public bool Deleted { get;  set; }
        
        public DateTime? DeleteTimeUtc { get; set; }
        
        public string CreatedBy { get; set; } = String.Empty;
        
        public DateTime CreatedOnUtc { get; set; }
        
        public string? ModifiedBy { get; set; }
        
        public DateTime? ModifiedOnUtc { get; set; }
    }
}
