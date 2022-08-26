using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs_KS.Models
{
    public class JobTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Job Type")]
        public string JobType { get; set; }
    }
}