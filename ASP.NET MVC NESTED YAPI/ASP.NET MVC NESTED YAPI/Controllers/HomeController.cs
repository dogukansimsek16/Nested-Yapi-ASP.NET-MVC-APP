using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_NESTED_YAPI.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            List<Notes> list = new List<Notes>();
            using (VeriTabanimEntities dc = new VeriTabanimEntities())
            {
                list = dc.Notes.OrderBy(a => a.NoteID).ToList();
            }
                return View();
        }
    }
}