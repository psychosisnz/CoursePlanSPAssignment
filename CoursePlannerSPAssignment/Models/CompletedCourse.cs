using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoursePlannerSPAssignment.Models
{
    public class CompletedCourse
    {
        [Key]
        public int CompleteId { get; set; }

        public virtual Course Course { get; set; }
        public int CourseId { get; set; }

        [Display(Name = "Course was Passed?  ")]
        public bool Passed { get; set; }

        [RegularExpression(@"\d{4}")]
        [Display(Name = "Completed In Year ")]
        public string YearCompleted { get; set; }

        [RegularExpression(@"\d{1}")]
        [Display(Name = "Completed In Semester ")]
        public string SemesterCompleted { get; set; }

        public virtual Student Student { get; set; }
        public string ApplicationUserId { get; set; }



    }
}