using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBackend.Controllers
{
    public class AsiakkaatController : Controller
    {
        public IActionResult Index()
        {
            NorthwindContext context = new NorthwindContext();
            List<Customers> asiakkaat = context.Customers.ToList();

            // Uusi luotaisiin näin
            //Customers uusi = new Customers()
            //{
            //    CompanyName = "Ideanikkarit Oy",
            //    City = "Joensuu",
            //    Country = "Finland"
            //};

            //context.Customers.Add(uusi);
            //context.SaveChanges();

            return View(asiakkaat);
        }

        public IActionResult LuoUusi()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult LuoUusi(Customers uusi)
        {
            NorthwindContext context = new NorthwindContext();
            context.Customers.Add(uusi);
            context.SaveChanges();

            return View();
        }
    }
}