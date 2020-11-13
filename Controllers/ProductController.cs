using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Espresso()
        {
            return View();
        } 
        
        public IActionResult Cappucino()
        {
            return View();
        }

        public IActionResult Latte()
        {
            return View();
        }
    }
}
       