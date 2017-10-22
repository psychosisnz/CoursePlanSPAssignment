using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoursePlannerSPAssignment.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [StringLength(4)]
        [Display(Name ="Course Code ")]
        public string CourseCode { get; set; }

        [Display(Name = "Course Name ")]
        public string CourseName { get; set; }


        [Required]
        [RegularExpression(@"\d{1}")]
        public string Semester { get; set; }

        [Required]
        [RegularExpression(@"\d{1}")]
        public string Year { get; set; }

        public virtual Topic Topic { get; set; }
        public int TopicId { get; set; }

        [Display(Name = "Prerequisite ")]
        public string PreReq { get; set; }

        public bool Compulsory { get; set; }
    }
}