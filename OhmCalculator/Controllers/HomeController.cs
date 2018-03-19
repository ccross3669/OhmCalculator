using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OhmCalculator.Library;
namespace OhmCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ResistorCalculations value = new ResistorCalculations("asdfdfsdf");

            var test = value.GetbandValues();


            return View();
        }

        
    }
}