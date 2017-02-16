using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.ViewModels
{
    public class LoginViewModel
    {
        [StringLength(7, ErrorMessage = "User Name should not be greater than 7")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}