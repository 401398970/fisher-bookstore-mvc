using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("books");
        } 
        public IActionResult New()
        {
            return Content("new");
        } 
        public IActionResult bestsellers()
        {
            return Content("best-sellers");
        } 
    }
}           