using Federated.Models.Clinicians;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Federated.Models
{
    public class Outcomes
    {
       
      


       

        public IList<clinicians_disease_duration_in_cat2> clinicians_Disease_Duration_In_Cat2s { get; set; }

        public IList<clinicians_edss_in_cat2> clinicians_Edss_In_Cat2s { get; set; }

        public IList<clinicians_has_comorbidities> clinicians_Has_Comorbidities { get; set; }

        public IList<clinicians_ms_type2> clinicians_Ms_Type2s { get; set; }

        public IList <clinicians_sex_binary> clinicians_Sex_Binaries { get; set; }

        public IList<clinicians_age_in_cat> clinicians_Age_in_Cats { get; set; }

        public IList<clinicians_dmt_type_overall> clinicians_Dmt_Type_Overalls { get; set; }


    }
}
