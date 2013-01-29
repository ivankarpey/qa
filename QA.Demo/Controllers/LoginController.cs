using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QA.Demo.Models;

namespace QA.Demo.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            throw new NotImplementedException();
        }

    }
}
