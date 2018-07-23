using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thlem.Models
{
    public class CompanySubViewModel
    {
        public int Id { get; set; }
        [Required]
        public String ProjectName { get; set; }
        [Required]
        public String Link1 { get; set; }
        public String Link2 { get; set; }
        [Required]
        public String Description { get; set; }
        public String File { get; set; }

    }
}
