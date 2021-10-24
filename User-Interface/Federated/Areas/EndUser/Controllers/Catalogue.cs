using Federated.Models;
using Federated.Models.Clinicians;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Federated.Areas.EndUser.Controllers
{
    [Area("EndUser")]
    public class Catalogue : Controller
    {


        

        public IActionResult Loading()
        {
            return View();

        }



        public IActionResult Index()
        {
            

                var webClient = new WebClient();
                var jsoncAge = webClient.DownloadString("C:/Users/ashka/iCloudDrive/Desktop/PhD/Projects/COVID19-GDSI2021-Dashboard/Federated/wwwroot/Scripts/Python/MSDA_Querry3/Outputs/clinicians-age_in_cat.json");
                var jsoncDMT = webClient.DownloadString("C:/Users/ashka/iCloudDrive/Desktop/PhD/Projects/COVID19-GDSI2021-Dashboard/Federated/wwwroot/Scripts/Python/MSDA_Querry3/Outputs/clinicians-dmt_type_overall.json");
                var jsoncEDSS = webClient.DownloadString("C:/Users/ashka/iCloudDrive/Desktop/PhD/Projects/COVID19-GDSI2021-Dashboard/Federated/wwwroot/Scripts/Python/MSDA_Querry3/Outputs/clinicians-edss_in_cat2.json");
                var jsoncMST = webClient.DownloadString("C:/Users/ashka/iCloudDrive/Desktop/PhD/Projects/COVID19-GDSI2021-Dashboard/Federated/wwwroot/Scripts/Python/MSDA_Querry3/Outputs/clinicians-ms_type2.json");
                var jsoncSEX = webClient.DownloadString("C:/Users/ashka/iCloudDrive/Desktop/PhD/Projects/COVID19-GDSI2021-Dashboard/Federated/wwwroot/Scripts/Python/MSDA_Querry3/Outputs/clinicians-sex_binary.json");


                var cAGE = JsonConvert.DeserializeObject<clinicians_age_in_cat>(jsoncAge);
                var cDMT = JsonConvert.DeserializeObject<clinicians_dmt_type_overall>(jsoncDMT);
                var cEDSS = JsonConvert.DeserializeObject<clinicians_edss_in_cat2>(jsoncEDSS);
                var cMST = JsonConvert.DeserializeObject<clinicians_ms_type2>(jsoncMST);
                var cSEX = JsonConvert.DeserializeObject<clinicians_sex_binary>(jsoncSEX);




                Outcomes outcomes = new Outcomes
                {
                    clinicians_Age_in_Cats = new List<clinicians_age_in_cat> { cAGE },
                    clinicians_Dmt_Type_Overalls = new List<clinicians_dmt_type_overall> { cDMT },
                    clinicians_Edss_In_Cat2s = new List<clinicians_edss_in_cat2> { cEDSS },
                    clinicians_Ms_Type2s = new List<clinicians_ms_type2> { cMST },
                    clinicians_Sex_Binaries = new List<clinicians_sex_binary> { cSEX }
                };

              


                    return View(outcomes);
                
            


        }
    }
}
