using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReportsCoreSamples.Controllers
{
    public class CustomerSupportAnalysisController : PreviewController
    {
        public IActionResult Index()
        {
            this.updateMetaData();
            return View();
        }
    }
}