using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyApp.Entities
{
    [Table("Trainings")]
    public class Training
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MinLength(5)]
        [MaxLength(255)]
        public string Title { get; set; }
        [MinLength(5)]
        [MaxLength(255)]
        public string Description { get; set; }
        [MinLength(1)]
        [MaxLength(100)]
        public string Anchor { get; set; }

        public float Duration { get; set; }
    }
}