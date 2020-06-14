using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lifect.Models
{
    public class MuscleGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_MuscleGroup { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageMuscleGroup { get; set; }
        public string About { get; set; }
    }
}