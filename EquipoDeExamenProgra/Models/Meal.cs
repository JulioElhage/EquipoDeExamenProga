using System.ComponentModel.DataAnnotations;

namespace EquipoDeExamenProgra.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string User { get; set; } = string.Empty;

        [Required]
        public DateTime EntryDate { get; set; }

        [Required]
        public string FoodName { get; set; } = string.Empty;

        [Required]
        public int Calories { get; set; }

        [Required]
        public int Protein { get; set; }

        [Required]
        public int Carbs { get; set; }

        [Required]
        public int Fat { get; set; }
    }
}