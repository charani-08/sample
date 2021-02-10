using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class moviesController : Controller
    {
        masterEntities1 entity = new masterEntities1();
        // GET: movies
        public ActionResult show()
        {
            var data = entity.tblemployees.ToList();
            return View(data);
        }
        public ActionResult update()
        {
            return View();
        }
        public ActionResult insert()
        {
            return View();
        }
        //changed insert operation

        [HttpPost]
        public ActionResult insert( tblemployee emp)
        {
            masterEntities2 entity = new masterEntities2();
            tblemployee obj = new tblemployee();
            obj.firstname = emp.firstname;
            obj.lastname = emp.lastname;
            obj.address = emp.address;
            obj.phone = emp.phone;
            entity.tblemployees.Add(obj);
            entity.SaveChanges();
            return RedirectToAction("show");
        }
        

        
    }
}