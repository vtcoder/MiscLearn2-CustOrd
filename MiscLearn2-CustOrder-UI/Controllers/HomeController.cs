using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MiscLearn2_CustOrder_UI.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MiscLearn2_CustOrder_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel() { HomeTitle = "Custom home title!" };
            return View(homeViewModel);
        }
    }
}
