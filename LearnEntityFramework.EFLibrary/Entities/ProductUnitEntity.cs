using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.EFLibrary.Entities
{
    [Table("product_unit")]
    public class ProductUnitEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; } = string.Empty;
    }
}
