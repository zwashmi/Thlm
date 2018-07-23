using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using thlem.Data.Eintities;

namespace thlem.Models
{
    public class SubmtionPrjectsViewModel
    {

        public int Id { get; set; }
        [Required]
        public CompanySubmition CompanySubmition { get; set; }
        [Required]
        public ResearcherSubmition ResearcherSubmition { get; set; }
        public int Price { get; set; }

    }
}
