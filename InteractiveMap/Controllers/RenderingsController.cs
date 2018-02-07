using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InteractiveMap.Controllers
{
    public class RenderingsController : Controller
    {
        // GET: Renderings
        public ActionResult Index()
        {
            string testVariable = "this is to test git";
            return View("Map");
        }
    }
}