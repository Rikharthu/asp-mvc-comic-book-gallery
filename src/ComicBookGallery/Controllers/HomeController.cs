using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    /// <summary>
    /// Without supplying the path, MVC will route to HomeController's Index()
    /// </summary>
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()   
        {
            return "Homepage";
        }
    }
}