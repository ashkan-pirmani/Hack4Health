using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Federated.Models.Clinicians
{
    public class clinicians_has_comorbidities
    {
        public int yes { get; set; }
        public int no { get; set; }
        public int missing { get; set; }
    }
}
