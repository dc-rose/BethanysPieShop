﻿using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class ContactController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}