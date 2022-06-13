using Eticaret_02.MvcWebUI.Entity;
using Eticaret_02.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret_02.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var item = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id          = i.Id,
                    Name        = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 10) + "..." : i.Description,
                    Star        = i.Star,
                    StocCode    = i.StocCode,
                    PriceOld    = i.PriceOld,
                    PriceNew    = i.PriceNew,
                    ImageSmall  = i.ImageSmall,
                    CategoryId  = i.CategoryId
                }
                ).ToList();

            return View(item);
        }


        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }


        public ActionResult List(int? id)
        {
            var item = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 10) + "..." : i.Description,
                    Star = i.Star,
                    StocCode = i.StocCode,
                    PriceOld = i.PriceOld,
                    PriceNew = i.PriceNew,
                    ImageSmall = i.ImageSmall,
                    CategoryId = i.CategoryId
                }
                ).AsQueryable();

            //Kategorinin id bilgisi gelir
            if (id != null)
            {
                item = item.Where(i => i.CategoryId == id);
            }


            return View(item.ToList());
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}