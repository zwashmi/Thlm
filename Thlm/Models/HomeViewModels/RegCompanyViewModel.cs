using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thlem.Models
{
    public class RegCompanyViewModel
    {

        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Brief { get; set; }
        [Required]
        public String Location { get; set; }
        public String Image { get; set; }

    }
}
