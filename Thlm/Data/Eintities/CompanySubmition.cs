using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace thlem.Data.Eintities
{
    public class CompanySubmition
    {
        public int Id { get; set; }
        public String ProjectName { get; set; }
        public String Link1 { get; set; }
        public String Link2 { get; set; }
        public String Description { get; set; }
        public String File { get; set; }

    }
}
