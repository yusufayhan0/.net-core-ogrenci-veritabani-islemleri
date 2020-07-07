using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstProject.Models;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private dbcontext context =new dbcontext(); 
        public IActionResult Index()
        {
            var veriler = context.ogrencilers.OrderByDescending(m=>m.ID).ToList();
            return View(veriler);
        }
        public ActionResult siltemp(int id)
        {
            ogrenciler ogrenciler = context.ogrencilers.Find(id);
            context.ogrencilers.Remove(ogrenciler);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ekle()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ekle(ogrenciler ogrenciler)
        {
                context.ogrencilers.Add(ogrenciler);
                context.SaveChanges();
            

            return View();
        }
        public IActionResult guncelle(int? id)
        {
            ogrenciler ogrenciler = context.ogrencilers.Find(id);
            return View(ogrenciler);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult guncelle(ogrenciler ogrenciler)
        {
            ogrenciler guncel = context.ogrencilers.Find(ogrenciler.ID);
            guncel.ad = ogrenciler.ad;
            guncel.soyad = ogrenciler.soyad;
            guncel.no = ogrenciler.no;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
