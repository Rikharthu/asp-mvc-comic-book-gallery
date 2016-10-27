using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
  
    /// <summary>
    /// Our Controller class.
    /// "Conroller" suffix is mandatory, for Visual Studio to distinguish controllers.
    /// Must extend the Controller class
    /// </summary>
    public class ComicBooksController : Controller
    {
        // Default url routing <host>/<controller name>/<method name>

        ///<summary>
        /// Implement our Action methods (must be public).
        /// By default routed to path: /ComicBooks/Detail.
        /// </summary>
        public string Detail()
        {
            return "Hello from the comic books controller!";
        }

        // ContentResult and RedirectResult extend ActionResult
        public ActionResult Details()
        {
            // ContentResult is a return type MVC provides
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                // redirect user to the main page if it is wednesday today
                // NOTE: will redirect to <host>/ rather than <host>/<controller name>/
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content = "Hello from the comic books controller!"
            };

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

        public string Index()
        {
            return "This is ComicBooks Controller's index page";
        }
    }
}