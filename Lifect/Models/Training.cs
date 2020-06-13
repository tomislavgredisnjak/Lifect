using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lifect.Models
{
    public class Training
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Training { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public string ImageTraining { get; set; }

    }
}