using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thlem.Models
{
    public class RegResearvherViewModel
    {

        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public DateTime BirthDay { get; set; }
        [Required]
        public String Skills { get; set; }
    }
}
