using obajans.clas;
using obajans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace obajans.Controllers
{
    [HandleError]
    public class DefaultController : Controller
    {
        
     
           public ActionResult hakkimizda()
            {
                return View();
            }
    
        public ActionResult Index(int page,string category)
        {
            datacontext db = new datacontext();
            ortakmodel nesne = new ortakmodel();
            if (category.ToLower()=="siyaset")
            {
                if (page < 1)
                {
                    page = 1;
                }
                if (page > (db.haberler.Where(q => q.konu=="Siyaset").ToList().Count() / 14) + 1)
                {
                    page = (db.haberler.Where(q => q.konu == "Siyaset").ToList().Count() / 14) + 1;
                }

                Element eleme = new Element();
                int element = (page * 14) - 14;
                try
                {
                    nesne.haber = db.haberler.Where(q => q.konu == "Siyaset").OrderByDescending(p => p.id).Skip(element).Take(14).ToList();
                }
                catch (Exception)
                {
                    nesne.haber = db.haberler.Where(q => q.konu == "Siyaset").OrderByDescending(p => p.id).Take(14).ToList();
                    // RedirectToAction("Index", beforePage.beforeIndexpage);
                }
                ViewData["Category"] = "Siyaset";
                ViewData["Pagenum"] = eleme.Pagelist(page, db.haberler.Where(q => q.konu == "Siyaset").ToList().Count());
                return View(nesne);
            }
            if (category.ToLower()=="spor")
            {

                if (page < 1)
                {
                    page = 1;
                }
                if (page > (db.haberler.Where(q => q.konu == "Spor").ToList().Count() / 14) + 1)
                {
                    page = (db.haberler.Where(q => q.konu == "Spor").ToList().Count() / 14) + 1;
                }

                Element eleme = new Element();
                int element = (page * 14) - 14;
                try
                {
                    nesne.haber = db.haberler.Where(q => q.konu == "Spor").OrderByDescending(p => p.id).Skip(element).Take(14).ToList();
                }
                catch (Exception)
                {
                    nesne.haber = db.haberler.Where(q => q.konu == "Spor").OrderByDescending(p => p.id).Take(14).ToList();
                    // RedirectToAction("Index", beforePage.beforeIndexpage);
                }
                ViewData["Category"] = "Spor";
                ViewData["Pagenum"] = eleme.Pagelist(page, db.haberler.Where(q => q.konu == "Spor").ToList().Count());
                return View(nesne);
            }
            if (category.ToLower()=="para")
            {

                if (page < 1)
                {
                    page = 1;
                }
                if (page > (db.haberler.Where(q => q.konu == "Para").ToList().Count() / 14) + 1)
                {
                    page = (db.haberler.Where(q => q.konu == "Para").ToList().Count() / 14) + 1;
                }

                Element eleme = new Element();
                int element = (page * 14) - 14;
                try
                {
                    nesne.haber = db.haberler.Where(q => q.konu == "Para").OrderByDescending(p => p.id).Skip(element).Take(14).ToList();
                }
                catch (Exception)
                {
                    nesne.haber = db.haberler.Where(q => q.konu == "Para").OrderByDescending(p => p.id).Take(14).ToList();
                    // RedirectToAction("Index", beforePage.beforeIndexpage);
                }
                ViewData["Category"] = "Para";
                ViewData["Pagenum"] = eleme.Pagelist(page, db.haberler.Where(q => q.konu == "Para").ToList().Count());
                return View(nesne);
            }
            if (category.ToLower() == "farkli")
            {

                if (page < 1)
                {
                    page = 1;
                }
                if (page > (db.haberler.Where(q => q.konu == "Farklı").ToList().Count() / 14) + 1)
                {
                    page = (db.haberler.Where(q => q.konu == "Farklı").ToList().Count() / 14) + 1;
                }

                Element eleme = new Element();
                int element = (page * 14) - 14;
                try
                {
                    nesne.haber = db.haberler.Where(q => q.konu == "Farklı").OrderByDescending(p => p.id).Skip(element).Take(14).ToList();
                }
                catch (Exception)
                {
                    nesne.haber = db.haberler.Where(q => q.konu == "Farklı").OrderByDescending(p => p.id).Take(14).ToList();
                    // RedirectToAction("Index", beforePage.beforeIndexpage);
                }
                ViewData["Category"] = "Farkli";
                ViewData["Pagenum"] = eleme.Pagelist(page, db.haberler.Where(q => q.konu == "Farklı").ToList().Count());
                return View(nesne);
            }
            else
            {
                if (page < 1)
                {
                    page = 1;
                }
                if (page > (db.haberler.ToList().Count() / 14) + 1)
                {
                    page = (db.haberler.ToList().Count() / 14) + 1;
                }

                Element eleme = new Element();
                int element = (page * 14) - 14;
                try
                {
                    nesne.haber = db.haberler.OrderByDescending(p => p.id).Skip(element).Take(14).ToList();
                }
                catch (Exception)
                {
                    nesne.haber = db.haberler.OrderByDescending(p => p.id).Take(14).ToList();
                    // RedirectToAction("Index", beforePage.beforeIndexpage);
                }
                ViewData["Category"] = "hepsi";
                ViewData["Pagenum"] = eleme.Pagelist(page, db.haberler.ToList().Count());
                return View(nesne);
            }
            
        }
        public ActionResult Haber(int id)
        {
            datacontext db = new datacontext();
            ortakmodel nesne = new ortakmodel();
            NewsFinder news = new NewsFinder();
            try
            {
                if (news.getnew(id).icerik != "")
                {

                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            if (news.getnew(id).icerik != "")
            {
               
                ViewData["oncehaberler"] = db.haberler.Where(p => p.id < id).OrderByDescending(p => p.id).Take(4).ToList();
                ViewData["sonrahaberler"] = db.haberler.Where(p => p.id > id).OrderBy(p => p.id).Take(4).ToList();
                ViewData["ilkhaberler"] = db.haberler.OrderBy(p => p.id).Skip(1).Take(4).ToList();
                ViewData["sonhaberler"] = db.haberler.OrderBy(p => p.id).Skip(1).Take(4).ToList();
                return View(news.getnew(id));

            }

            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
