using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class UserDetails
    {
        [StringLength(7, ErrorMessage ="User Name should not be greater than 7")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}