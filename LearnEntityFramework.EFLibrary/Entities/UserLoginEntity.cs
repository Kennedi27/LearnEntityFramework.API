using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("user_login")]
    public class UserLoginEntity
    {
        public int UserName { get; set; }
        public string Password { get; set; } = string.Empty;
        public int RoleId { get; set; }
        public DateTime? LastLogin { get; set; }

    }
}
