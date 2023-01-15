using System.ComponentModel.DataAnnotations;

namespace LearnEntityFramework.EFLibrary.Abstractions
{
    internal interface IAuditableEntity
    {
        [Required]
        int CreatedBy { get; set; }
        [Required]
        DateTime CreatedOnUtc { get; set; }
        string? ModifiedBy { get; set; }
        DateTime? ModifiedOnUtc { get; set; }
    }
}
