﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {
            
            var cart = Session["cart"];
            Session.Clear();
            Session["cart"] = cart;
            return RedirectToAction("Index", "Home");
        }
    }
}