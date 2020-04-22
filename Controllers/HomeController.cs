﻿
using Foodrecipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnvisionAGreenLife.Controllers
{
    public class HomeController : Controller
    {
        FoodRecipesEntities4 db = new FoodRecipesEntities4();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Quiz()
        {
            ViewBag.Message = "How much do you know about saving money and energy?";

            return View();
        }

        public ActionResult Reuse()
        {
            ViewBag.Message = "Reuse";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description";

            return View();
        }

        public ActionResult Food(int? page)
        {
            ViewBag.Message = "Reduce food waste";
            return View();
        }
        public ActionResult AppliancesType()
        {
            ViewBag.Message = "Appliances Type";

            return View();
        }
    }
}