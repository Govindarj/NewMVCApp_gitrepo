using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMVCApp.Controllers;
using NewMVCApp.ViewModels;
using System.Web.Mvc;
using NewMVCApp.Models;
using System.Collections.Concurrent;
namespace NewMVCAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AccountViewModel avm = new AccountViewModel("abc","1234");
            //   avm.account.Username = "abc";
            // avm.account.Password = "1234";
              // avm.Username = "abc";
            //   avm.Password = "1234";
              //AccountController ac = new AccountController();
              //ViewResult ar = ac.Login(avm) as ViewResult;
              //Assert.AreEqual("Welcome", ar.ViewName, "loginsuccess");
              AccountController controller = new AccountController();
              var result = controller.Login(avm) as ViewResult;
              Assert.AreEqual("Welcome", result.ViewName);
              /*var controller = new AccountController();
              var expected = "Welcome";
              var actual = ((ViewResult)controller.Index()).ViewName;
              Assert.AreEqual(expected, actual);*/

        }
        [TestMethod]
        public void TestMethod2()
        {
            AccountViewModel avm = new AccountViewModel("abcd","123");
            AccountController controller = new AccountController();
            var result = controller.Login(avm) as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
           

        }
        [TestMethod]
        public void TestMethod3()
        {
            AccountViewModel avm = new AccountViewModel("abc", "1234");
            AccountController controller = new AccountController();
            var result = controller.Login(avm) as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
            
        }
    }
}
