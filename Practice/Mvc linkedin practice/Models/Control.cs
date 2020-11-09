using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_linkedin_practice.Models
{
    public class Control
    {
        [Required]
        [StringLength(100, MinimumLength =5, ErrorMessage ="Error")]
        public string Title { get; set; }
        [Required]
        public string Name { get; set; }
        public string Id { get; set; }
        public string Age { get; set; }
        public string Place { get; set; }

    }
}
