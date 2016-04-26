using Site.Data;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class ErrorLogController : Controller
    {
        // GET: ErrorLog
        public ActionResult Index()
        {
            var list = new List<Log4net>();
            using (var db = new SiteContext())
            {
                db.Log4nets.Add(new Log4net()
                {
                    Level = "ERROR",
                    Logger = "Hand",
                    Host = "127.0.0.1",
                    Date = DateTime.Now,
                    Thread = "0",
                    Message = "",
                    Exception = ""
                });
                db.SaveChanges();
                list = db.Log4nets.OrderByDescending(i => i.Id).Take(10).ToList();
            }

            return View(list);
        }
    }
}