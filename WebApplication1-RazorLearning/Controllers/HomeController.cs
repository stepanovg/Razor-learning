﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_RazorLearning.Models;

namespace WebApplication1_RazorLearning.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Kayak",
            Description = "A boat for one person",
            Price = 275m
        };
        // GET: Home
        public ActionResult Index()
        {
            return View(myProduct);
        }
    }
}