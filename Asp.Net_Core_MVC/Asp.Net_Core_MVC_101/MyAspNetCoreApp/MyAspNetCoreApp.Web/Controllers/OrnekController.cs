﻿using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.name = "Asp.Net Core";

            //ViewBag.name = new List<string>() { "ahmet", "mehmet", "hasan" };

            return View();
        }

        public IActionResult Index2()
        {
            //veritabanı kaydetme işlemi
            return RedirectToAction("Index", "Ornek");
        }

        public IActionResult ParametreView(int id)
        {


            return RedirectToAction("JsonResultParametre", "Ornek", new { id = id });
        }

        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id });
        }

        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }

        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "kalem 1", price = 100 });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}