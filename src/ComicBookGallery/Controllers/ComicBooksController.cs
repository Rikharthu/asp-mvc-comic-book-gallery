using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ComicBookGallery.Controllers
{
  
    /// <summary>
    /// Our Controller class.
    /// "Conroller" suffix is mandatory, for Visual Studio to distinguish controllers.
    /// Must extend the Controller class
    public class ComicBooksController : Controller
    {
        // Default url routing <host>/<controller name>/<method name>

        ///<summary>
        /// Implement our Action methods (must be public).
        /// By default routed to path: /ComicBooks/Detail.
        /// </summary>
        public string Details()
        {
            return "Hello from the comic books controller!";
        }

        // ContentResult and RedirectResult extend ActionResult
        public ActionResult Detail()
        {
            // set data to a ViewBag (objec to pass data from Controller to a View)
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };


            return View();
            /* By default (without specified name - uses method name (Details)) will look in those folders:
                ~/Views/Comicbooks/details.aspx
                ~/Views/Comicbooks/details.ascx
                ~/Views/Shared/details.aspx
                ~/Views/Shared/details.ascx
                ~/Views/Comicbooks/details.cshtml
                ~/Views/Comicbooks/details.vbhtml
                ~/Views/Shared/details.cshtml
                ~/Views/Shared/details.vbhtml
                */
            

        }

        // http://localhost:52536/comicbooks/saymyname?name=Richard
        public string SayMyName(string name)
        {
            // name parameter is automaticalle set to variable name
            return $"Hello, {name}!";
        }

        // http://localhost:52536/comicbooks/sum?number1=12&number2=6
        public string Sum()
        {
            // retrieve parameters from request
            int a = Int32.Parse(Request.QueryString["number1"]);
            int b = Int32.Parse(Request.QueryString["number2"]);
            return a + b + "";
        }

        // http://localhost:52536/comicbooks/sum?number1=12&number2=6
        public string Ban()
        {
            // retrieve parameters from request
            int a = Int32.Parse(Request.QueryString["number1"]);
            int b = Int32.Parse(Request.QueryString["number2"]);
            return a + b + "";
        }

        public ActionResult Index()
        {
            //return "This is ComicBooks Controller's index page";
            return new RedirectResult("/ComicBooks/Detail");
        }
    }
}