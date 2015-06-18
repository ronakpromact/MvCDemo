using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCronak.Controllers
{
    public class helloworldController : Controller
    {
        // GET: helloworld
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult  welcome(String name,int numtimes=1)
        {
            ViewBag.Message = "hello" + name;
            ViewBag.Numtimes = numtimes;
            return View();
        }
    }
}