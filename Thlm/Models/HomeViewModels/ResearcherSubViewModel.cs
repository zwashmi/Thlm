using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thlem.Models
{
    public class ResearcherSubViewModel
    {

        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String ProjectName { get; set; }
        [Required]
        public String Text { get; set; }
    }
}
