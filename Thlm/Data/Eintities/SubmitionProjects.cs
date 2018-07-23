using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thlem.Data.Eintities
{
    public class SubmitionProjects
    {
        public int Id { get; set; }
        public CompanySubmition CompanySubmition { get; set; }
        public ResearcherSubmition ResearcherSubmition { get; set; }
        public int Price { get; set; }
    }
}
