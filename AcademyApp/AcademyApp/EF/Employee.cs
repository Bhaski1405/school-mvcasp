using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyApp.EF
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        public string Email { get; set; }
         [MinLength(5)]
        [MaxLength(50)]
        public string Alias { get; set; }
    }
}