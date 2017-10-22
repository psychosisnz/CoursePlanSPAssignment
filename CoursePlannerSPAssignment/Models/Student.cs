using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoursePlannerSPAssignment.Models
{
    public class Student
    {
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Key]
        public string ApplicationUserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        public string Email { get; set; }


    }
}