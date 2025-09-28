using System.ComponentModel.DataAnnotations;

namespace EquipoDeExamenProgra.Models
{
    public class Habit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string User { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string Frequency { get; set; } = string.Empty; // Ej: "Diario", "Semanal", etc.

        [Required]
        public bool Status { get; set; } // true = activo, false = inactivo
    }
}