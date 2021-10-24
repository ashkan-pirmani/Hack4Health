using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Federated.Areas.EndUser.Controllers
{
    public class DataGenerator : Controller
    {

        [Area("EndUser")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
