using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoursePlannerSPAssignment.Models
{
    public class Selection
    {
        [Key]
        public int SelectionId { get; set; }

        public virtual Student Student { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual Course Course { get; set; }
        [Display(Name ="Course ")]
        public int CourseId { get; set; }





    }
}