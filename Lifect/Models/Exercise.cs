using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lifect.Models
{
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Exercise { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int MusclesId { get; set; }
        [Required]
        public int Reps { get; set; }
        [Required]
        public int Sets { get; set; }
        [Required]
        public string ImageExercise { get; set; }
    }
}