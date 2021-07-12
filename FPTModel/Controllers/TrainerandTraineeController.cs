using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FPTModel;

namespace FPTModel.Controllers
{
    public class TrainerandTraineeController : Controller
    {
        private ASMWEBEntities3 db = new ASMWEBEntities3();

        // GET: TrainerandTrainee
        public ActionResult Index()
        {
            var couse_Cat = db.Couse_Cat.Include(c => c.Cours).Include(c => c.Role).Include(c => c.User);
            return View(couse_Cat.ToList());
        }

        // GET: TrainerandTrainee/Details/5
    }
}
