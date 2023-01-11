using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("payment_mode")]
    public class PaymentModeEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public bool Active { get; set; } = true;

        [Required]
        public int ViewShort { get; set; }
    }
}
