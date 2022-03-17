using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //return "Home";
            return View(); //or return View(Index);
        }

        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}