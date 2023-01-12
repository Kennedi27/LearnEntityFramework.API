using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("product")]
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Code { get; set; } = String.Empty;
        [Required, MaxLength(50)]
        public string Name { get; set; } = String.Empty;
        public int UnitId { get; set; }
        public double Stock { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
    }
}
