using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QA.Demo.Models
{
    public class LoginModel
    {
        [Display(Name="User name")]
        public String UserName { get; set; }

        [Display(Name="Password")]
        public String Password { get; set; }

        public String Token { get; set; }
    }
}