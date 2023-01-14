using System.ComponentModel.DataAnnotations;

namespace LearnEntityFramework.EFLibrary.Entities
{
    public class PaymentModeEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public bool Active { get; set; }

        [Required]
        public int ViewShort { get; set; }
    }
}
