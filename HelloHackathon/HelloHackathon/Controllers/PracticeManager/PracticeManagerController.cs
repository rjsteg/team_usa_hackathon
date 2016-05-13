using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloHackathon.Controllers.PracticeManager
{
    public class PracticeManagerController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            using()

            return View();
        }
    }
}