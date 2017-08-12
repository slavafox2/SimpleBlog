﻿using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Home");

        }
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            FormsAuthentication.SetAuthCookie(form.Username, true); //Authentication

            if (!string.IsNullOrWhiteSpace(returnUrl)){
                return Redirect(returnUrl);
            }
            return RedirectToRoute("Home");
        }
    }

}