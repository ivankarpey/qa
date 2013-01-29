using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QA.WebAPI.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult LogIn(String userName, String password)
        {
            //Check user credentials, returning hashcode and logining user in the system
            throw new NotImplementedException();
        }

        public ActionResult LogOut()
        {
            //GetUser hash from the cookies and logout it from the system disposing all users data
            throw new NotImplementedException();
        }

        public ActionResult LognInOpenID()
        {
            //Implementing login with openid
            throw new NotImplementedException();
        }

        public ActionResult LogInFB()
        {
            //Implementing login with facebook
            throw new NotImplementedException();
        }

        public ActionResult LogInGoogle()
        {
            //Implementing login with google
            throw new NotImplementedException();
        }
    }
}
