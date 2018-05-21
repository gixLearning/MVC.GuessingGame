using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.GuessingGame.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() {
            return View();
        }

        public ActionResult Contact() {
            return View();
        }

        public ActionResult Projects() {
            return View();
        }

        public ActionResult Fevercheck() {
            return View();
        }

        [HttpPost]
        public ActionResult FeverCheck(float? temperature, string useFarenheit) {
            if (temperature != null) {
                ViewData["temps"] = temperature;

                if (!useFarenheit.Equals("C")) {
                    ViewData["useFarenheit"] = true;
                } else {
                    ViewData["useFarenheit"] = false;
                }

                return View();
            }

            return View();
        }
    }
}