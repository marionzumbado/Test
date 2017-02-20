using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
//adding a simple comment 2
namespace Test.MyClassLib
{
    [TestFixture]
    public class GettingWorkDoneTests
    {
        [Test]
        public void IsUser_AuthenticatedAdmin_ReturnTrue()
        {
            var ebl = new EmployeeBusinessLayer();
            var ud = new UserDetails();
            ud.UserName = "Admin1";
            ud.Password = "Admin";
            var result = ebl.GetUserValidity(ud);
            Assert.AreEqual(result, UserStatus.AuthenticatedAdmin);
        }

        [Test]
        public void IsUser_AuthenticatedUser_ReturnTrue()
        {
            var ebl = new EmployeeBusinessLayer();
            var ud = new UserDetails();
            ud.UserName = "User";
            ud.Password = "User";
            var result = ebl.GetUserValidity(ud);
            Assert.AreEqual(result, UserStatus.AuthentucatedUser);
        }
    }
}
