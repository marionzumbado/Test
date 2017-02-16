using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

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
            ud.UserName = "Admin98";
            ud.Password = "Admin98";
            var result = ebl.GetUserValidity(ud);
            Assert.AreEqual(result, UserStatus.AuthenticatedAdmin);
        }

        [Test]
        public void IsUser_AuthenticatedUser_ReturnTrue()
        {
            var ebl = new EmployeeBusinessLayer();
            var ud = new UserDetails();
            ud.UserName = "User1234567890";
            ud.Password = "User1234567890";
            var result = ebl.GetUserValidity(ud);
            Assert.AreEqual(result, UserStatus.AuthentucatedUser);
        }
    }
}
