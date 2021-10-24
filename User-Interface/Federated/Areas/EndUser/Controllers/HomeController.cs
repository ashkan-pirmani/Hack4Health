using Federated.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Federated.Areas.EndUser.Controllers
{
    [Area("EndUser")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //string filePathExecute = "wwwroot/Scripts/Bash/Clean.sh";
            //FileInfo fileInfo = new FileInfo(filePathExecute);
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.CreateNoWindow = false;
            //startInfo.UseShellExecute = true;
            //startInfo.FileName = "/bin/bash";
            //startInfo.Arguments = $"\"{fileInfo.FullName}\"";
            //Process process = Process.Start(startInfo);
            return View();


        }

        public IActionResult Home()
        {

            //string filePathExecute = "wwwroot/Scripts/Bash/Clean.sh";
            //FileInfo fileInfo = new FileInfo(filePathExecute);
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.CreateNoWindow = false;
            //startInfo.UseShellExecute = true;
            //startInfo.FileName = "/bin/bash";
            //startInfo.Arguments = $"\"{fileInfo.FullName}\"";
            //Process process = Process.Start(startInfo);
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
