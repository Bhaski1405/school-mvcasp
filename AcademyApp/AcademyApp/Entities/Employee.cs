using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AcademyApp.Entities {

    [Table("Employees")]
    public class Employee {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MinLength(5)]
        [MaxLength(255)]
        public string Alias { get; set; }

        [MinLength(5)]
        [MaxLength(255)]
        public string Email { get; set; }
    }
}