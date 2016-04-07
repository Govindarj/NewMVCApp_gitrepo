using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewMVCApp.ViewModels;
using NewMVCApp.Models;

namespace NewMVCApp.Controllers
{
    public class AccountController : Controller
    {
       
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
           
                if (avm.Username.Equals("abc") && avm.Password.Equals("1234"))
                {
                    //Session["username"] = avm.Username;
                    return View("Welcome");
                }
                else {
                    ViewBag.Error = "Account Invalid";
                    return View("Index");
                }
           }
    }
}