using MVCApplication.Framework;
using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }


        public ActionResult Test()
        {
            ViewBag.Message = "Message in Bag";
            ViewData["blah"] = "Blah fromv view data";
            Session["hello"] = "session message";
            System.Web.HttpContext.Current.Cache["stuff"] = "Cache stuff";
            return View("Index");
        }

        private byte[] GetBytes()
        {
            byte[] b = new byte[10];
            return b;
        }



       
    }
}