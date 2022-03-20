using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using efcodefirstapproach.Models;


namespace efcodefirstapproach.Controllers
{
    public class HomeController : Controller
    {
        studentcontext db = new studentcontext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(student s)
        {
            if(ModelState.IsValid==true)
            {
                db.students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    //ViewBag.InsertMessage = "<script>alert('Data Inserted !!')</script>";
                   // TempData["InsertMessage"] = "<script>alert('Data Inserted !!')</script>";
                    TempData["InsertMessage"] = "Data Inserted !!";
                    return RedirectToAction("Index");
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data Not Inserted !!')</script>";

                }
            }
            

            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.students.Where(model => model.id == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(student s)
        {
            if(ModelState.IsValid==true)
            {
                db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    // ViewBag.UpdateMessage = " < script > alert('Data Updated !!') </ script > ";
                    // TempData["UpdateMessage"] = " < script > alert('Data Updated !!') </ script > ";
                    TempData["UpdateMessage"] = "Data Updated !!";
                    return RedirectToAction("Index");

                    // ModelState.Clear();
                }
                else
                {
                    ViewBag.UpdateMessage = " < script > alert('Data Not Updated !!') </ script > ";
                }
            }
            
            return View();
        }

    }

}