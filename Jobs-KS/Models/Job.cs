using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs_KS.Models
{
    public class Job
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image {get; set;}
        [Display(Name = "Job Type")]
        [Required]
        public int JobTypeId { get; set; }
        [ForeignKey("JobTypeId")]
        public virtual JobTypes JobTypes { get; set; }

    }
}
