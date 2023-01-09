using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    public class CustomerEntity
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
    }
}
