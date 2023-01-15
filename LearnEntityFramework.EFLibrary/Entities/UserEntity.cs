using LearnEntityFramework.EFLibrary.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    public class UserEntity : ISoftDeleteEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;

        [Required, MaxLength(20)]
        public string UserName { get; set; } = String.Empty;

        [Required, MaxLength(20)]
        public string LastName { get; set; } = String.Empty;

        public bool Active { get; set; }

        public bool Deleted { get;  set; }
        
        public DateTime? DeleteTimeUtc { get; set; }
        public DateTime? LastLogin { get; set; }

    }
}
