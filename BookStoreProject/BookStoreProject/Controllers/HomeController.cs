using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //return "Home";
            ViewData["title"] = "viewdata";
            ViewData["book"] = new BookModel() { Category = "kids", TotalPages = 234, Language = "Hindi", Discription = "This is the description for Java book", Id = 8, Title = "Java", Author = "Shivam" };

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