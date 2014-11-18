using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA2Revision.Models;

namespace CA2Revision.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Calculate()
        {
            //the Viewbag name here must be that of the variable name in the model other the Model State will be invalid
            ViewBag.InstanceSize = new SelectList ( AzureCloudService.InstanceSizeDescription );
            return View(new AzureCloudService() { NumInstances = 2 });
        }

        [HttpPost]
        public ActionResult Calculate(AzureCloudService Service)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Confirm", Service);
            }
            ViewBag.InstanceType = new SelectList(AzureCloudService.InstanceSizeDescription);
            return View(Service);
        }

        public ActionResult Confirm(AzureCloudService Service)
        {
            //ViewBag.Message = "Your contact page.";

            return View(Service);
        }
    }
}