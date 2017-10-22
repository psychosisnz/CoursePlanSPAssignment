using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoursePlannerSPAssignment.Models
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }

        [Required]
        [Display(Name ="Topic ")]
        public string TopicName { get; set; }

    }
}