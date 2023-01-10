using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("user_role")]
    public class UserRoleEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; } = String.Empty;
    }
}
